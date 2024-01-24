using Microsoft.AspNetCore.Mvc;

namespace UsuariosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastraUsuario()
    {
        throw new NotImplementedException();
    }
}
