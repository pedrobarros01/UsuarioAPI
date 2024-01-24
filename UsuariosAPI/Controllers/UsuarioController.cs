using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTOs;

namespace UsuariosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastraUsuario(CreateUsuarioDTO dto)
    {
        throw new NotImplementedException();
    }
}
