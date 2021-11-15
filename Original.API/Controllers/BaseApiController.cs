using Microsoft.AspNetCore.Mvc;

namespace Original.API.Controllers
{
    /// <summary>
    /// Base API controller for common API behaviour
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {
        }
    }
}
