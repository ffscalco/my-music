using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MyMusic.Api.Resources;
using MyMusic.Api.Validators;
using System.Threading.Tasks;
using AutoMapper;

namespace MyMusic.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("")]
        public async Task<ActionResult<LoggedResource>> Login([FromBody] LoginResource loginResource)
        {
            var validator = new LoginValidator();
            var validationResult = await validator.ValidateAsync(loginResource);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            if (loginResource.Username == "netengine" &&
                loginResource.Password == "qwerty!23456")
            {
                var loggedResource = new LoggedResource();
                loggedResource.Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6.IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIy.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_a";

                return Ok(loggedResource);
            }
            else
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
        }
    }
}
