using Educacion.Negocio;
using Educacion.Negocio.Entidades;
using System;

namespace Educacion.Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos!");

            Estudiante estudiante = new Estudiante
            {
                Nombre = "Jhon",
                Apellido = "Acosta",
                Nacimiento = new DateTime(1999, 5, 13)
            };
            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programacion Visual"
             };
            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Ingles"
            };
            Secretaria secretaria0 = new Secretaria();
            secretaria0.Matricular(estudiante, asignatura);

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Matricular(estudiante, asignatura1);

            Console.WriteLine($"Hay {Secretaria.Matriculados} estudaintes matriculados");
            Console.ReadKey();
        }
    }
}
