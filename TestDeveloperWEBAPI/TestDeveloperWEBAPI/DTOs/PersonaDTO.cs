using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeveloperWEBAPI.DTOs
{
    public class PersonaDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
    }
}
