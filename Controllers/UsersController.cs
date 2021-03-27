using RestAPI.Models;
using RestAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : Controller 
    {
        private readonly UserService _userService;

        public UsersController( UserService userService)
        {
            _userService = userService;
        }
         [HttpGet]
         public ActionResult<List<User>> GetUsers([FromQuery] int count) =>
             _userService.Get();

    }
}