using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_1.Models;

namespace WebApp_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeaconController : ControllerBase
    {
        private readonly DashboardDBContext _context;

        public BeaconController(DashboardDBContext context)
        {
            _context = context;
        }

        // GET: api/Beacon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beacon>>> GetBeacons()
        {
            return await _context.Beacons.ToListAsync();
        }

        // GET: api/Beacon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Beacon>> GetBeacon(int id)
        {
            var Beacon = await _context.Beacons.FindAsync(id);

            if (Beacon == null)
            {
                return NotFound();
            }

            return Beacon;
        }

        // PUT: api/Beacon/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBeacon(int id, Beacon Beacon)
        {
            Beacon.ID = id;

            //if (id !=Beacon.ID)
            //{
            //    return BadRequest();
            //}


            _context.Entry(Beacon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeaconExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Beacon
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Beacon>> PostBeacon(Beacon Beacon)
        {
            _context.Beacons.Add(Beacon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeacon", new { id = Beacon.ID }, Beacon);
        }

        // DELETE: api/Beacon/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Beacon>> DeleteBeacon(int id)
        {
            var Beacon = await _context.Beacons.FindAsync(id);
            if (Beacon == null)
            {
                return NotFound();
            }

            _context.Beacons.Remove(Beacon);
            await _context.SaveChangesAsync();

            return Beacon;
        }

        private bool BeaconExists(int id)
        {
            return _context.Beacons.Any(e => e.ID == id);
        }
    }
}
