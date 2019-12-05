using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VertaJaLuita
{
    class Battle
    {
        //StartFight funktio
        //Warrior1 Warrior2
        public static void StartFight(Warrior
            warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        
        }


        //loop että vuorotellen hyökätään ja puolustetaan kunnes toinen kuolee. HP-->0

        //Anna hyökkäyksen tulos
        public static string GetAttackResult
            (Warrior warriorA, Warrior warriorB)
        {
            double warAAttackAmt = warriorA.Attack();
            double warBBttackAmt = warriorB.Block();

            double dmg2WarB = warAAttackAmt - warBBttackAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} hyökkää {1} vastaan ja aiheuttaa {2} vahinkoa", warriorA.Name, warriorB.Name,dmg2WarB);
            Thread.Sleep(TimeSpan.FromMilliseconds(100)); // pysäytetään ohjelma millisekunneksi että olis mukavempi katsoa
            Console.WriteLine("{0} on {1} energiaa jäljellä \n", warriorB.Name, warriorA.Health);
            

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} on kuollut ja {1} on VOITTAJA!!\n", warriorB.Name, warriorA.Name);
                return "Game over";
                
            }
            else return "Game over!";
        }
        
        //näytä laskut hyökkäyksisät ja puolustuksista

        //jos hyökkäys menee läpi, vähennä se kohteen hp:sta

        //printtaa kuka hyökkäs ja ketä vastaan kuinka suurella damagella




    }
}
