using Microsoft.AspNetCore.Mvc;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PayoutController : ControllerBase
    {
        /// <summary>
        /// All payout actions will be done here.
        /// </summary>
        /// <returns></returns>

        private readonly ILogger<PayoutController> _log;
        public PayoutController(ILogger<PayoutController> log)
        {
            _log = log;
        }
     
    }
}
