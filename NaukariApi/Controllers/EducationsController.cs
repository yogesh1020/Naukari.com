
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
    public class EducationsController : ControllerBase
    {
        private readonly NaukariContext _context;

        public EducationsController(NaukariContext context)
        {
            _context = context;
        }

        // GET: api/Educations
        [HttpGet]
        public IEnumerable<Educations> GetEducations()
        {
            return _context.Educations;
        }

        // GET: api/Educations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEducations([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var educations = await _context.Educations.FindAsync(id);

            if (educations == null)
            {
                return NotFound();
            }

            return Ok(educations);
        }

        
        // POST: api/Educations
        [HttpPost]
        public IActionResult PostEducations([FromForm] Educations educations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Educations.Add(educations);
             _context.SaveChanges();

            return CreatedAtAction("GetEducations", new { id = educations.EducationId }, educations);
        }

        

        
    }
}