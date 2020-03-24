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
    public class UsersController : ControllerBase
    {
        private readonly NaukariContext _context;

        public UsersController(NaukariContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            return _context.Users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public  IActionResult GetUsers([FromRoute] int id)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Users user = new Users();
            user = _context.Users.Find(id);
            user.Employments = _context.Employments.Where(a=>a.UserId == user.UserId).FirstOrDefault();
            user.Educations = _context.Educations.Where(a => a.UserId == user.UserId).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        
        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUsers([FromForm] Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(users);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsersExists(users.UserId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsers", new { id = users.UserId }, users);
        }

        

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}