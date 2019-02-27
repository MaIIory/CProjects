using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TankRentals.Models;

// Use DTO to transfer objects in this controller - Addition date has been hide

namespace TankRentals.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanksController : ControllerBase
    {
        private TanksContext _tanksDbContext;

        //Dependency Injection of DB context
        public TanksController(TanksContext tanksDbContext)
        {
            _tanksDbContext = tanksDbContext;
        }

        //GET /api/tanks/
        [HttpGet] 
        public async Task<ActionResult<IEnumerable<TankDto>>> GetTanks()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tanksInDb = await _tanksDbContext.Tanks.Include(t => t.TankType).ToListAsync();
            var tanksDto = new List<TankDto>();

            foreach(Tank t in tanksInDb)
            {
                var dtoTank = new TankDto() { Id = t.Id, Model = t.Model, NumberInGarage = t.NumberInGarage, ReleaseDate = t.ReleaseDate, TankType = t.TankType, TankTypeId = t.TankTypeId };
                tanksDto.Add(dtoTank);
            }

            return tanksDto;
        }

        //GET /api/tanks/1
        [HttpGet("{id}")]
        public async Task<ActionResult<TankDto>> GetTank(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tank = await _tanksDbContext.Tanks.Include(t => t.TankType).FirstOrDefaultAsync<Tank>(t => t.Id == id);

            if (tank == null)
                return NotFound();

            var tankDto = new TankDto() { Id = tank.Id, Model = tank.Model, NumberInGarage = tank.NumberInGarage, ReleaseDate = tank.ReleaseDate, TankType = tank.TankType, TankTypeId = tank.TankTypeId };

            return tankDto;
        }

        //POST /api/tanks/
        [HttpPost]
        public async Task<ActionResult<TankDto>> PostTank(TankDto tank)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Tank newTank = new Tank()
            {
                DateAdded = DateTime.Now,
                Model = tank.Model,
                NumberInGarage = tank.NumberInGarage,
                ReleaseDate = tank.ReleaseDate,
                TankTypeId = tank.TankTypeId
            };

            _tanksDbContext.Tanks.Add(newTank);
            await _tanksDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTank), new { id = tank.Id }, tank);
        }

        //PUT /api/tanks/1
        [HttpPut("{id}")]
        public async Task<ActionResult> PutTank(int id, TankDto tank)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var dbTank = await _tanksDbContext.Tanks.FirstOrDefaultAsync(t => t.Id == id);

            if (dbTank == null)
                return NotFound();

            dbTank.Model = tank.Model;
            dbTank.NumberInGarage = tank.NumberInGarage;
            dbTank.ReleaseDate = tank.ReleaseDate;
            dbTank.TankTypeId = dbTank.TankTypeId;

            await _tanksDbContext.SaveChangesAsync();

            return NoContent();
        }

        //DELETE /api/tanks/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTank(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var dbTank = await _tanksDbContext.Tanks.FirstOrDefaultAsync(t => t.Id == id);

            if (dbTank == null)
                return NotFound();

            _tanksDbContext.Tanks.Remove(dbTank);
            await _tanksDbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}