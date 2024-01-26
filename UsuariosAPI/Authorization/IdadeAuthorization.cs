using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsuariosAPI.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
        var dataNascimentoClaim = context.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.DateOfBirth);
        if(dataNascimentoClaim is  null)
        {
            return Task.CompletedTask;
        }
        var dataNascimento = Convert.ToDateTime(dataNascimentoClaim.Value);
        int idade = DateTime.Today.Year - dataNascimento.Year;
        if(dataNascimento > DateTime.Today.AddYears(-idade))
        {
            idade--;
        }
        if(idade >= requirement.Idade)
        {
            context.Succeed(requirement);
        }
        return Task.CompletedTask;
    }
}
