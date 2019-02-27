using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TankRentals.Models;
using TankRentals.ViewModels;

namespace TankRentals.Controllers
{
    public class TanksController : Controller

    {
        private readonly TanksContext _tanksDbContext;

        public TanksController(TanksContext tanksContext)
        {
            //constructor call handled by the platform -> nice!
            _tanksDbContext = tanksContext;
        }
    
        //Actions
        // GET: Tanks/Random
        public IActionResult Random()
        {
            var tank = new Tank() { Model = "Sherman" };
            var viewData = new RandomTankViewModel
            {
                Tank = tank,
                Customer = new Customer() { Id = 0, Name = "Lukas" }
            };

            return View(viewData);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex is null)
                pageIndex = 0;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Model";

            return Content(String.Format("pageIndex={0},sortBy={1}",pageIndex,sortBy));
        }

        [Route("tanks/produced/{year}/{month:regex(^\\d{{2}}$):range(1,12)}")]
        public IActionResult ByProductionDate(int year, int month)
        {
            return Content("year: " + year.ToString() + ", month: " + month);
        }

        [Route("Tanks")]
        public IActionResult ListTanks()
        {
            var tanksList = _tanksDbContext.Tanks.Include(t => t.TankType).ToList<Tank>();
            return View("TanksTable", tanksList);
        }

        [Route("Tanks/Details/{id}")]
        public IActionResult Details(int id)
        {
            var tanks = _tanksDbContext.Tanks.Include(t => t.TankType).FirstOrDefault(t => t.Id == id);
            return View("Details", tanks);
        }

        [Route("Tanks/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var newTankViewModel = new NewTankViewModel()
            {
                FormName = "Edit Tank",
                Tank = _tanksDbContext.Tanks.First<Tank>(t => t.Id == id),
                TankType = _tanksDbContext.TankType.ToList<TankType>()
            };

            return View("TankForm", newTankViewModel);
        }

        public IActionResult New()
        {
            var newTankViewModel = new NewTankViewModel()
            {
                FormName = "Add Tank",
                Tank = new Tank(),
                TankType = _tanksDbContext.TankType.ToList<TankType>()

            };

            return View("TankForm", newTankViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(NewTankViewModel tankViewModel, string command)
        {
            if (command.Equals("cancel"))
            {
                return RedirectToAction("ListTanks");
            }
            else if (command.Equals("delete"))
            {
                RemoveTank(tankViewModel.Tank);
                return RedirectToAction("ListTanks");
            }
            else
            {
                //AddOrEdit(Tank)
                if (!ModelState.IsValid)
                {
                    tankViewModel.TankType = _tanksDbContext.TankType.ToList<TankType>();
                    return View("TankForm", tankViewModel);
                }

                Tank tank = tankViewModel.Tank;
                tank.DateAdded = DateTime.Now;

                var dbTank = _tanksDbContext.Tanks.FirstOrDefault<Tank>(t => t.Id == tank.Id);

                if (dbTank == null)
                    _tanksDbContext.Tanks.Add(tank);
                else
                {
                    dbTank.TankTypeId = tank.TankTypeId;
                    dbTank.ReleaseDate = tank.ReleaseDate;
                    dbTank.Model = tank.Model;
                    dbTank.NumberInGarage = tank.NumberInGarage;
                }

                _tanksDbContext.SaveChanges();

                return RedirectToAction("ListTanks");
            }
        }

        public void RemoveTank(Tank tank)
        {
            try
            {
                var tankToRemove = _tanksDbContext.Tanks.Single(c => c.Id == tank.Id);
                _tanksDbContext.Tanks.Remove(tankToRemove);
                _tanksDbContext.SaveChanges();
            }
            catch (Exception)
            {
                //Do nothing, just suppress the error
            }
        }
    }
}