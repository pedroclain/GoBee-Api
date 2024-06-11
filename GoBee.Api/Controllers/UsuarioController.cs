using GoBee.UseCases.Usuarios.CriarUsuario;
using GobeeApi.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GoBee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController(ICriarUsuario criarUsuarioUseCase) : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<CriarUsuarioOutput>>> CriarUsuario([FromBody] CriarUsuarioInput body)
        {
            var caseResult = await criarUsuarioUseCase.Executar(body);
            var result = ApiResponse<CriarUsuarioOutput>.BuildSuccess(caseResult);

            return Ok(result);
        }
    }
}
