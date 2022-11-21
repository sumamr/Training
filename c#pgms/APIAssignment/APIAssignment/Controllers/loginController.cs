using APIAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly userContext _dbContext;

        public loginController(userContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> Loginusers(string emai,string pass,user user)
        {
            if (emai!= user.email && pass!=user.password)
            {
                return NotFound();
            }
            var display = _dbContext.users.Where(m => m.email == emai && m.password == pass).FirstOrDefault();
            if (display == null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(Loginusers), new { emai = user.email,pass=user.password}, display);
            
        }
        
       

    }
}
