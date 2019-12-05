using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertaJaLuita
{
    class Warrior
    {
        //nimi, hp, attackMax, blockMax
        public string Name { get; set; } =
            "Warrior";
        public double Health { get; set; } = 0;
        public double AttakMax { get; set; }=0;
        public double BlockMax { get; set; } = 0;

        //random arvot
        Random rnd = new Random();

        //Hyökkäys
        //Random arvo hyökkäykselle
        public Warrior(string name = "warrior",
            double health = 0,
            double attakMax = 0,
            Double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttakMax = attakMax;
            BlockMax = blockMax;
        }
        public double Attack()
        {
            return rnd.Next(1, (int)AttakMax);
        }

        //Puolustus
        //random arvo puolustukselle

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


    }
}
