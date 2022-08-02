using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NTS.RadioBadge.Service.Controllers.Parts
{
    [Route("/part")]
    [ApiController]
    public class PartsController : ControllerBase
    {

        #region Operations
        [HttpGet("check")]
        public async Task<IActionResult> CheckWheel()
        {
            return Ok("Все круто");
        }
        #endregion
    }
}

