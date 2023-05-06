using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriPlan.Models;

namespace NutriPlan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Customer>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
