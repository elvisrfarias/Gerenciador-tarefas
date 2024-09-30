using GerenciadorAplication.UseCases.Tarefas.GetAll;
using GerenciadorAplication.UseCases.Tarefas.Register;
using GerenciadorComunication.Requests;
using GerenciadorComunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Controllers;
[Route("v1/[controller]")]
[ApiController]
public class GerencidorTarefaController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseAllTarefaJson), StatusCodes.Status200OK)]
    public IActionResult GetAll([FromRoute] int id)
    {
        var useCase = new GetAllTarefaUseCases();
        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var response = new TarefaRegisterUseCases().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestTarefaJson request)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
