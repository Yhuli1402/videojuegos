using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudianteController : ControllerBase
    {
    
        private readonly ILogger<EstudianteController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EstudianteController(
            ILogger<EstudianteController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [HttpPost(Name = "GetEstudiante")]
        public IActionResult Post(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Student.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        [HttpPut(Name = "GetEstudiante")]
        public IActionResult Put([FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Student.Update(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //Update: Modificar estudiantes
        [HttpGet(Name = "GetEstudiante")]
        public IEnumerable<Estudiante> Get()
        {
            return _aplicacionContexto.Student.ToList();
        }
        //Delete: Eliminar estudiantes
        [HttpDelete(Name = "GetEstudiante")]
        public IActionResult Delete(int estudianteId)
        {
            _aplicacionContexto.Student.Remove(
                _aplicacionContexto.Student.ToList()
                .Where(x => x.IdStudent == estudianteId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(estudianteId);
        }
    }
}