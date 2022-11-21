using APIAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly userContext _dbContext;

        public userController(userContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<user>>> GetMovies()
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            return await _dbContext.users.ToListAsync();
        }

        // GET: api/user/5
        [HttpGet("{id}")]
        public async Task<ActionResult<user>> Getuser(int id)
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            var movie = await _dbContext.users.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }
        // POST: api/user
        [HttpPost]
        public async Task<ActionResult<user>> Postuser(user user)
        {
            _dbContext.users.Add(user);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Getuser), new { id = user.Id }, user);
        }
        // PUT: api/user/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser(int id, user user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(user).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userExists(id))
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
        // DELETE: api/user/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser(int id)
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }

            var user = await _dbContext.users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _dbContext.users.Remove(user);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        private bool userExists(long id)
        {
            return (_dbContext.users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
