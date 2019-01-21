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
            //constructor call i handled by the platform
            _tanksDbContext = tanksContext;
        }
    
        //Actions
        // GET: Tanks/Random
        public IActionResult Random()
        {
            var tank = new Tank() { Model = "Sherman" };
            var viewData = new RandomTankViewModel();
            viewData.Tank = tank;
            viewData.Customer = new Customer() { Id = 0, Name = "Lukas" };

            return View(viewData);
        }

        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
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
            var tank = _tanksDbContext.Tanks.Include(t => t.TankType).FirstOrDefault(t => t.Id == id);
            return View("Details", tank);
        }
    }
}