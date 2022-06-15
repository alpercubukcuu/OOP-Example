using System;
using EmlakciLib;

namespace EmlakciEvApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev[] evler = new Ev[]
            {
                new SatilikEv(5,3,"Fatih",110,15000,350000),
                new KiralikEv(5, 3, "test", 110, 2000, 2500),
                new SatilikEv(5,3,"İstanbul",110,15000,350000),
                new KiralikEv(5, 3, "test25", 110, 2000, 2500)
            };

            //foreach (var ev in evler)
            //{
            //    if(ev is KiralikEv)
            //    {
            //        Console.WriteLine("Kiralık Ev Bilgileri");
            //        Console.WriteLine("--------------------");
            //        Console.WriteLine((ev as KiralikEv).GetirEvBilgisi());
            //    }

            //    else
            //    {
            //        Console.WriteLine("Satılık Ev Bilgileri");
            //        Console.WriteLine("--------------------");   
            //        Console.WriteLine((ev as SatilikEv).GetirEvBilgisi());      =============>>>    Polimorphism Kulanılmamış hali
            //    }
            //    Console.WriteLine("\n");
            //}

            foreach (var ev in evler)
            {
                Console.WriteLine(ev.GetirEvBilgisi());
                                                                       // ======================>>>   Polimorphism Kullanılmış Hali...
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
