using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice
{
    public class Heroe
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }

        //Constructor con parametros
        public Heroe(string name, int hp, int mp, string @class, int level, string gender, string description)
        {
            Name = name;
            Hp = hp;
            Mp = mp;
            Class = @class;
            Level = level;
            Gender = gender;
            Description = description;
        }

        //Constructor sin parametros
        public Heroe()
        {

        }

        public override string ToString()
        {
            String result = "";

            result += "Nombre :" + Name;
            result += "HP :" + Hp;
            result += "MP :" + Mp;
            result += "Clase :" + @Class;
            result += "Nivel :" + Level;
            result += "Genero :" + Gender;
            result += "Descripcion :" + Description;
        }
    }
}

