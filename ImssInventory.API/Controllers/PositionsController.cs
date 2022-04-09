#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ImssInventory.API.Models;
using Microsoft.AspNetCore.Authorization;
using ImssInventory.API.DTOs;

namespace ImssInventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly ImssInventoryContext _context;

        public PositionsController(ImssInventoryContext context)
        {
            _context = context;
        }

        // GET: api/Positions
        [HttpGet]
        public IEnumerable<PositionDTO> GetPositions()
        {
            //return await _context.Positions.ToListAsync();
            List<PositionDTO> list = (from pos in _context.Positions
                                      select new PositionDTO
                                      {
                                          Id = pos.PositionId,
                                          PositionName = pos.PositionName,
                                      }
                                      ).ToList();
            return list;
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Position>> GetPosition(int positionId)
        {
            var position = await _context.Positions.FindAsync(positionId);

            if (position == null)
            {
                return NotFound();
            }

            return position;
        }

        // PUT: api/Employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int EmployeeId, Employee employee)
        {
            if (EmployeeId != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(EmployeeId))
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

        // POST: api/Positions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("add/")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<PositionDTO>> PostPosition([FromBody] PositionDTO position)
        {
            var newPosition = new Position
            {
                PositionName = position.PositionName
        };

            _context.Positions.Add(newPosition);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(position), newPosition);
        }

        // DELETE: api/Position/5
        [Route("delete")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosition(int Position)
        {
            
            var position = await _context.Positions.FindAsync(Position);
            if (position == null)
            {
                return NotFound();
            }

            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
