using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeAlumnos
{
    public class Personas
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int dni;

        public Personas(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        // Otros métodos y funcionalidades de la clase Personas
    }
}
