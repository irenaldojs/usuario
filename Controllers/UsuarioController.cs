using Microsoft.AspNetCore.Mvc;
using usuario.Models;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios()
        {
            return new List<Usuario> {
                new Usuario{Id = 1,Nome = "Irenaldo"}
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }
    }
}
