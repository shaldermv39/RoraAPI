using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RoraAPI.Model;

namespace RoraAPI.Controller
{
    // [ServiceFilter(typeof(UserActivities))]
    [ApiController]
    [Route("[controller]/[Action]")] 
    [Authorize]
    public class AuthController : ControllerBase
    {
        IConfiguration _config;
        APIDBContext _dbContext;
        public AuthController(APIDBContext dbcontext, IConfiguration config)
        {
            _config = config;
            _dbContext = dbcontext;
        }

        [HttpGet]
        [AllowAnonymous]
        [ActionName("Login")]
        public IActionResult Login()
        {

            var claims = new[]
            {
                 new Claim(ClaimTypes.NameIdentifier, "userid"),
                 new Claim(ClaimTypes.Name,"username")
             };
            var key = new SymmetricSecurityKey
                (Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            var cred =
                new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var tokedescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = cred
            };
            var tokenhandler = new JwtSecurityTokenHandler();
            var tkn = tokenhandler.CreateToken(tokedescriptor);

            //RET
            var t = new
            {
                token = tokenhandler.WriteToken(tkn)
            };
            return Ok(t);
            //return Ok("sujit");
        }

    }
}