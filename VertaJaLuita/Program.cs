using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VertaJaLuita

{
    class Program
    {
        static void AloitusIlmoitus()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("-V-------V--VVVVV---VVVV--VVVVV-------V--------------------------------");
            Console.WriteLine("--V-----V---V-------V--V----V--------V-V-------------------------------");
            Console.WriteLine("---V---V----VVVVV---VVVV----V-------VVVVV------------------------------");
            Console.WriteLine("----V-V-----V-------V-V-----V------V-----V-----------------------------");
            Console.WriteLine("-----V------VVVVV---V--V----V-----V-------V----------------------------");
            Console.WriteLine("------------------JA---------------------------------------------------");
            Console.WriteLine("---L-------L----L----L----LLLLL-------L--------------------------------");
            Console.WriteLine("---L-------L----L----L------L--------L-L-------------------------------");
            Console.WriteLine("---L-------L----L----L------L-------LLLLL------------------------------");
            Console.WriteLine("---L-------L----L----L------L------L-----L-----------------------------");
            Console.WriteLine("---LLLLL---LLLLLL----L------L-----L-------L------------Paina Enter...--");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ReadLine();
            Console.WriteLine("\n\nTässä ohjelmassa 2 gladiaattoria taistelevat keskenään kuolemaan saakka!\n\n");
            Console.ReadLine();
        }



        static void Main(string[] args) // vaihdoin staticista publiciksi
        {

            AloitusIlmoitus();
            


            Warrior Tappelija1 = new Warrior //tehdään uusi warrior olio nimeltään Tappelija1
                ("Tappelija1",400, 80, 50); //nimi, hp, attack, block

            Warrior Tappelija2 = new Warrior //tehdään uusi warrior olio nimeltään Tappelija2 
               ("Tappelija2", 400, 80, 50); //nimi, hp, attack, block

            Console.WriteLine("Anna NIMI gladiaattorille numero1 \n");
            Tappelija1.Name = Console.ReadLine();

            Console.WriteLine("Anna NIMI gladiaattorille numero2 \n");
            Tappelija2.Name = Console.ReadLine();

            Battle.StartFight(Tappelija1, Tappelija2); // tappelun aloitus, ketkä tappelee
           
            Console.ReadLine();
            
        }
    }
    
}
//Seuraavaksi niin että käyttäjä syöttää nimet taistelijoille !OK!
//Hahmoluokat? (eri hyökkäys ja puolustuspisteet)

    // Luultavasti kehitän tätä vielä eteenpäin, nyt vaan alkaa olla takki niin tyhjä tälle vuotta että saa olla.. - Arttu