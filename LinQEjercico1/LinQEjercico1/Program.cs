using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQEjercico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona> {
            new Persona {Nombre = "Juan",Edad = 25,Ciudad="Lima"},
            new Persona {Nombre = "María",Edad = 30,Ciudad="Bogotá"},
            new Persona {Nombre = "Pedro",Edad = 35,Ciudad="Madrid"},
            new Persona {Nombre = "Ana",Edad = 20,Ciudad="Lima"},
            new Persona {Nombre = "José",Edad = 40,Ciudad="Buenos Aires"}
            };
            Console.WriteLine("\n- Ejemplo del ejercico \n");

            var consulta = from p in personas
                           where p.Edad < 25 && p.Ciudad == "Lima"
                           orderby p.Nombre descending
                           select new { p.Nombre, p.Edad };
            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad}) años");
            }
            Console.WriteLine("\n- Persona que tengan 30 años y Vivan en Bogota \n");
            var consulta2 = from e in personas
                            where e.Edad >= 30 && e.Ciudad == "Bogotá"
                            orderby e.Nombre
                            select new { e.Nombre, e.Ciudad, e.Edad };
            foreach (var persona2 in consulta2)
            {
                Console.WriteLine($"{persona2.Nombre} ({persona2.Ciudad}) Ciudad");
            }
            var consulta3 = from e in personas
                            where e.Edad >= 25 && e.Edad <= 35
                            orderby e.Nombre
                            select new { e.Nombre, e.Edad };
            Console.WriteLine("\n- Persona que tengan una edad entre 25 y 35 años, Ordenaso por nombre \n");
            foreach (var persona3 in consulta3)
            {
                Console.WriteLine($"{persona3.Nombre} ({persona3.Edad}) Edad");
            }
        }
    }
    internal class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

    }
}
