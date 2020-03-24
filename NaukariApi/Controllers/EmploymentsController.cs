using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Naukari.Models;

namespace Naukari.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentsController : ControllerBase
    {
        private readonly NaukariContext _context;

        public EmploymentsController(NaukariContext context)
        {
            _context = context;
        }

        // GET: api/Employments
        [HttpGet]
        public IEnumerable<Employments> GetEmployments()
        {
            return _context.Employments;
        }

        // GET: api/Employments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployments([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employments = await _context.Employments.FindAsync(id);

            if (employments == null)
            {
                return NotFound();
            }

            return Ok(employments);
        }

        // POST: api/Employments
        [HttpPost]
        public IActionResult PostEmployments([FromForm] Employments employments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employments.Add(employments);
            _context.SaveChanges();

            return CreatedAtAction("GetEmployments", new { id = employments.EmploymentId }, employments);
        }


        private bool EmploymentsExists(int id)
        {
            return _context.Employments.Any(e => e.EmploymentId == id);
        }
    }
}