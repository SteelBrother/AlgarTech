using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDeveloperWEBAPI.DTOs;
using TestDeveloperWEBAPI.Entidades;
using TestDeveloperWEBAPI.Negocio;

namespace TestDeveloperWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        IAplicacion<Persona> _persona;
        public PersonaController(IAplicacion<Persona> Persona)
        {
            _persona = Persona;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _persona.GetAllAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _persona.GetByIdAsync(id);

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Save(PersonaDTO personaDTO)
        {
            var persona = new Persona()
            {
                Nombre = personaDTO.Nombre,
                Apellido = personaDTO.Apellido,
                FechaNacimiento = personaDTO.FechaNacimiento,
                Edad = personaDTO.Edad,
            };

            await _persona.SaveAsync(persona);
            return Ok(persona);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, PersonaDTO personaDTO)
        {
            if (id == 0 || personaDTO == null) return NotFound();

            var tmp = _persona.GetById(id);
            if (tmp != null)
            {
                tmp.Nombre = personaDTO.Nombre;
                tmp.Apellido = personaDTO.Apellido;
                tmp.FechaNacimiento = personaDTO.FechaNacimiento;
                tmp.Edad = personaDTO.Edad;
            }
            await _persona.SaveAsync(tmp);
            return Ok(tmp);

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return NotFound();

            _persona.DeleteAsync(id);
            return Ok();
        }
    }
}
