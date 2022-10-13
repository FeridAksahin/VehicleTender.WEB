using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        /// <summary>
        /// All Integration actions will be done here.
        /// </summary>
        /// <returns></returns>

        private readonly ILogger<IntegrationController> _log;
        public IntegrationController(ILogger<IntegrationController> log)
        {
            _log = log;
        }
  
    }
}
