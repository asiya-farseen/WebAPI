using assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment.Controllers
{
    public class LoginController : Controller
    {
       private readonly assignmentContext _dbContext;

            public LoginController(assignmentContext dbContext)
            {
                _dbContext = dbContext;
            }
            [HttpPost]
        public async Task<ActionResult<User>> PostLogin(Login login)
        {
            var user = await _dbContext.Users.Where(u => u.Email == login.email).FirstOrDefaultAsync();
            if (user?.Password == login.password && user != null)
                return user;
            else
                return NotFound();
        }
    }
}

  