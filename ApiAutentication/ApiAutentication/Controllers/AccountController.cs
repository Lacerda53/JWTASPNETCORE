using ApiAutentication.Models;
using ApiAutentication.Repositories;
using ApiAutentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiAutentication.Controllers
{
    [Route("account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User item)
        {
            var user = UserRepository.Get(item.UserName, item.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });
            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
