﻿using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : Controller
    {
        /// <summary>
        /// All Login actions will be done here.
        /// </summary>
        /// <returns></returns>

        private readonly ILogger<LoginController> _log;
        public LoginController(ILogger<LoginController> log)
        {
            _log = log;
        }
        [HttpGet("")]
        public IActionResult GetIndex()

        {
            return Ok();
        }
        [HttpPut("")]
        public IActionResult PutIndex()
        {
            return Ok();
        }
        [HttpPost("")]
        public IActionResult PostIndex()
        {
            return Ok();
        }
        [HttpDelete("")]
        public IActionResult DeleteIndex()
        {
            return Ok();
        }
    }
}
