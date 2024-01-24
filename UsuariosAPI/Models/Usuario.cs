using Microsoft.AspNetCore.Identity;

namespace UsuariosAPI.Models;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }
    public Usuario() : base() { }

    
}
