using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abrimos el archivo JSON:
            string a = File.ReadAllText("Heroes.json");

            //Agregamos el archivo JSON a una Lista para utilizar LINQ:
            List<Heroe> Hero = JsonConvert.DeserializeObject<List<Heroe>>(a);
            Console.WriteLine("hola");

            ejer2();

        }

        public static void ejer2(List<Heroe> hero)
        {
            var genero = hero.Where(g => g.Gender == "Male");
            Console.WriteLine("Hombres :");
            foreach (var x in hero)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
