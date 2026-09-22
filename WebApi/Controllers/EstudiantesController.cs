using Dapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Modelos;

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

    // GET: api/Estudiantes
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        using var connection = _db.CreateConnection();

        var estudiantes = await connection.QueryAsync<Estudiantes>(
            "SELECT * FROM Estudiantes"
        );

        return Ok(estudiantes);
    }

    // GET: api/Estudiantes/1
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        using var connection = _db.CreateConnection();

        var estudiante = await connection.QueryFirstOrDefaultAsync<Estudiantes>(
            "SELECT * FROM Estudiantes WHERE Id = @Id",
            new { Id = id }
        );

        if (estudiante == null)
            return NotFound();

        return Ok(estudiante);
    }

    // POST: api/Estudiantes
    [HttpPost]
    public async Task<IActionResult> Post(Estudiantes estudiante)
    {
        using var connection = _db.CreateConnection();

        var sql = @"
            INSERT INTO Estudiantes
            (Nombre, FechaNacimiento, LugarNacimiento, FechaIngreso, Casa, VaritaMagica, TipoSangreMagica)
            VALUES
            (@Nombre, @FechaNacimiento, @LugarNacimiento, @FechaIngreso, @Casa, @VaritaMagica, @TipoSangreMagica)";

        await connection.ExecuteAsync(sql, estudiante);

        return Ok(estudiante);
    }

    // PUT: api/Estudiantes/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Estudiantes estudiante)
    {
        using var connection = _db.CreateConnection();

        var sql = @"
            UPDATE Estudiantes
            SET Nombre = @Nombre,
                FechaNacimiento = @FechaNacimiento,
                LugarNacimiento = @LugarNacimiento,
                FechaIngreso = @FechaIngreso,
                Casa = @Casa,
                VaritaMagica = @VaritaMagica,
                TipoSangreMagica = @TipoSangreMagica
            WHERE Id = @Id";

        var filas = await connection.ExecuteAsync(
            sql,
            new
            {
                Id = id,
                estudiante.Nombre,
                estudiante.FechaNacimiento,
                estudiante.LugarNacimiento,
                estudiante.FechaIngreso,
                estudiante.Casa,
                estudiante.VaritaMagica,
                estudiante.TipoSangreMagica
            });

        if (filas == 0)
            return NotFound();

        return Ok();
    }

    // DELETE: api/Estudiantes/1
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        using var connection = _db.CreateConnection();

        var filas = await connection.ExecuteAsync(
            "DELETE FROM Estudiantes WHERE Id = @Id",
            new { Id = id }
        );

        if (filas == 0)
            return NotFound();

        return Ok();
    }
}