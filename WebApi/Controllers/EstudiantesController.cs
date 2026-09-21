using Dapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly DapperDB _db;

    public EstudiantesController(DapperDB db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        using var connection = _db.CreateConnection();

        var estudiantes = await connection.QueryAsync(
            "SELECT * FROM Estudiantes"
        );

        return Ok(estudiantes);
    }
}

