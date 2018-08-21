using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Nombre.Add(new Alumno());
         


            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT1258";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "H16532";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ES852";

            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear();
         

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Número de materias: " + alumno.Materias.Count);

            foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
                
            }
            Console.ReadLine();
        }
    }
}
