using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvFinalHiramatsuMariaJose
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }
        public int Casado { get; set; }
        public float Salario { get; set; }

    }
}
