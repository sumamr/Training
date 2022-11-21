using APIAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class serviceproviderController : ControllerBase
    {
        private readonly userContext _dbContext;
        public serviceproviderController(userContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/serviceprovider
        [HttpGet]
        public async Task<ActionResult<IEnumerable<serviceprovider>>> GetMovies()
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            return await _dbContext.serviceproviders.ToListAsync();
        }
        // GET: api/serviceprovider/5
        [HttpGet("{id}")]
        public async Task<ActionResult<serviceprovider>> Getserviceprovider(int id)
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            var suma = await _dbContext.serviceproviders.FindAsync(id);

            if (suma == null)
            {
                return NotFound();
            }

            return suma;
        }
        // POST: api/serviceprovider
        [HttpPost]
        public async Task<ActionResult<serviceprovider>> Postserviceprovider(serviceprovider serviceprovider)
        {
            _dbContext.serviceproviders.Add(serviceprovider);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Getserviceprovider), new { id = serviceprovider.ID }, serviceprovider);
        }
        // PUT: api/serviceprovider/5

        [HttpPut("{id}")]
        public async Task<IActionResult> Putserviceprovider(int id, serviceprovider serviceprovider)
        {
            if (id != serviceprovider.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(serviceprovider).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!serviceproviderExists(id))
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
        // DELETE: api/serviceprovider/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteserviceprovider(int id)
        {
            if (_dbContext.serviceproviders == null)
            {
                return NotFound();
            }

            var serviceprovider = await _dbContext.serviceproviders.FindAsync(id);
            if (serviceprovider == null)
            {
                return NotFound();
            }

            _dbContext.serviceproviders.Remove(serviceprovider);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        private bool serviceproviderExists(long id)
        {
            return (_dbContext.serviceproviders?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
