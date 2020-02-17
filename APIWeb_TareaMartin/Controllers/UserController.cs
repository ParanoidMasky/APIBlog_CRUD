using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWeb_TareaMartin.Models;
using APIWeb_TareaMartin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIWeb_TareaMartin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserService userService)
        {
            _userService = userService;
            _logger = logger;
        }

        // GET: api/User  / Obtener usuarios registrados 
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User  / Postear nuevos users
        [HttpPost]
        public string Post([FromBody] User user)
        {
            //User user = new User { id = id, FirstName = FirstName, LastName = LastName, email = email, password = password };
            return _userService.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] User user)
        {
            return _userService.EditUser(id, user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
