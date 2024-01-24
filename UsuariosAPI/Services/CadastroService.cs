using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Data.DTOs;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services;

public class CadastroService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;

    public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task Cadastra(CreateUsuarioDTO dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);
        IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);
        if(!resultado.Succeeded)
        {
            throw new ApplicationException("Falha ao cadastrar usuário");
        }
    }
}
