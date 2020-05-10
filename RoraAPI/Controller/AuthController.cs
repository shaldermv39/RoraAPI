using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoraAPI.Model;

namespace RoraAPI.Controller
{
     [ServiceFilter(typeof(UserActivities))]
    [ApiController]
    [Route("[controller]/[Action]")] 
    [Authorize]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [ActionName("Login")]
        public IActionResult Login()
        {
            return Ok(201);
        }
        
    }
}