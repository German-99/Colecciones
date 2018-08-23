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
            //DECLARACION E INICIALIZACION DE LISTA DE ALUMNOS
            List<Alumno> alumnos = new List<Alumno>();
            //asigancion
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Jose Perez";
            alumno1.Materias.Add(new Materia("Historia", "HST741"));
            alumno1.Materias.Add(new Materia("Matematicas", "MAT741"));
            alumno1.Materias.Add(new Materia("Civismo", "CVC753"));
           
         

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Arturo  Lopez";
            alumno2.Materias.Add(new Materia("Español", "ESP637"));
            alumno2.Materias.Add(new Materia("Quimica", "QUI285"));
            alumno2.Materias.Add(new Materia("Programacion", "PROG756"));

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Juan Hernandez";
            alumno3.Materias.Add(new Materia("Fisica", "FIS052"));
            alumno3.Materias.Add(new Materia("Matematicas", "MAT391"));
            alumno3.Materias.Add(new Materia("Dibujo", "DIB891"));

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Maria  Gutierrez";
            alumno4.Materias.Add(new Materia("Dibujo", "DIB891"));
            alumno4.Materias.Add(new Materia("Quimica", "QUI285"));
            alumno4.Materias.Add(new Materia("Civismo", "CVC753"));

            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);

            foreach (Alumno elemento in alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);
                foreach(Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia:" + materia.Nombre);
                }
            }

            /*Materia matematicas = new Materia();
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
                
            }*/
            Console.ReadLine();
        }
    }
}
