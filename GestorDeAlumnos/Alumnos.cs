using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeAlumnos
{
    public class Alumnos : Personas
    {
        // Atributos adicionales de la clase Alumnos

        public string grado;
        public string carrera;

        // Constructor de Alumnos que llama al constructor de Personas
        public Alumnos(string nombre, string apellido, int edad, int dni, string grado, string carrera) : base(nombre, apellido, edad, dni)
        {
            this.grado = grado;
            this.carrera = carrera;
        }

        // Otros métodos y funcionalidades de la clase Alumnos
    }

}
