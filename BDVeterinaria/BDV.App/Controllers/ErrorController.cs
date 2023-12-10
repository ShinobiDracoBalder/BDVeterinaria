using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BDV.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public string ErrorAPI()
        {
            return "No tiene permiso para acceder a la API";
        }
    }
}
