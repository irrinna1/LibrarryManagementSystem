using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Identity.Data.Models;
using LibraryManagementSystem.Identity.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        public IdentityController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/<IdentityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IdentityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            var user = new User
            {
                Email = userDto.Email,
                UserName = userDto.Email,
                
            };

            var identityResult = await _userManager.CreateAsync(user, userDto.Password);
            
            var errors = identityResult.Errors.Select(e => e.Description);

            return Ok();

            //return identityResult.Succeeded
            //    ? Result<User>.SuccessWith(user)
            //    : Result<User>.Failure(errors);
        }

        // PUT api/<IdentityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IdentityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
