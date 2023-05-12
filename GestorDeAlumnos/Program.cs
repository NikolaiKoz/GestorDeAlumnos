using GestorDeAlumnos;
using System;

namespace Clases_y_Objetos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Crear una instancia de la clase Alumnos utilizando el constructor que llama al constructor de Personas
            Alumnos alumno1 = new Alumnos("Juan", "Perez", 25, 123456, "1ra Cohorte", "Programacion");

            // Acceder a los atributos heredados de Personas
            Console.WriteLine($"Nombre: {alumno1.nombre}");
            Console.WriteLine($"Apellido: {alumno1.apellido}");
            Console.WriteLine($"Edad: {alumno1.edad}");
            Console.WriteLine($"DNI: {alumno1.dni}");

            // Acceder a los atributos adicionales de Alumnos
            Console.WriteLine($"DNI: {alumno1.carrera}");
            Console.WriteLine($"Grado: {alumno1.grado}");

            // Otras operaciones o funcionalidades con la instancia de Alumnos
        }
    }
}
