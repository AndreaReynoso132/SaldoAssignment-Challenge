using Microsoft.AspNetCore.Mvc;
using SaldoAssignment.Domain.Entities;
using SaldoAssignment.ApplicationServices;
using SaldoAssignment.ApplicationServices.Models; 


[ApiController]
[Route("api/[controller]")]
public class SaldoController : ControllerBase
{
    private readonly ISaldoAssignmentService _saldoService;

    public SaldoController(ISaldoAssignmentService saldoService)
    {
        _saldoService = saldoService;
    }

    [HttpPost("asignar-saldos")]
    public IActionResult AsignarSaldos([FromBody] AsignacionSaldosRequest request)
    {
        if (request.Saldos == null || request.Saldos.Count == 0)
        {
            return BadRequest("La lista de saldos no puede estar vacía.");
        }

        if (request.Gestores == null || request.Gestores.Count == 0)
        {
            return BadRequest("La lista de gestores no puede estar vacía.");
        }

        _saldoService.AsignarSaldos(request.Saldos, request.Gestores);

        return Ok(request.Gestores); 
    }

}
