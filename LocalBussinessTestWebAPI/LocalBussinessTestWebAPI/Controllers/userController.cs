using LocalBussinessTestWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;



namespace LocalBussinessTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly dataContex _dbContext;





        public UserController(dataContex dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            if (_dbContext.Users == null)
            {
                return NotFound();
            }
            return await _dbContext.Users.ToListAsync();
        }





        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int Id)
        {
            if (_dbContext.Users == null)
            {
                return NotFound();
            }
            var User = await _dbContext.Users.FindAsync(Id);





            if (User == null)
            {
                return NotFound();
            }





            return User;
        }
        [HttpPost]
        public async Task<ActionResult<Users>> PostUser(Users user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();





            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Users>> DeleteUser(int Id)
        {
            var del = await _dbContext.Users.FindAsync(Id); 
            if (del == null)
            {
                return NotFound();
            }
          

            _dbContext.Users.Remove(del);
            await _dbContext.SaveChangesAsync();
            

            return NoContent();
        }
    }
}




