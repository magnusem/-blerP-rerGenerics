﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    class Program
    {
        static void Main(string[] args)
        {


            //var æble1 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            //var æble2 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            //Console.WriteLine("æble1 equals æble2: " + æble1.Equals(æble2));

            //Æbler æble3 = æble2;
            //Console.WriteLine("æble3 equals æble2: " + æble3.Equals(æble2));

            //var æble4 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };
            //Console.WriteLine("æble4 equals æble1: " + æble4.Equals(æble1));

            //Console.WriteLine(Object.ReferenceEquals(æble2, æble3));
            //Console.WriteLine(Object.ReferenceEquals(æble1, æble2));




            var pærerBeholdning = new List<Pærer>();
            pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 20M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 17, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });

            //Find alle elementer i listen hvor pris > 15 
            Console.WriteLine("Pris > 15");
            foreach (var item in pærerBeholdning.FindAll(x => x.Pris > 15))
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine();
            Console.WriteLine("Lager");
            //Find første element i listen hvor lager == 20
            Console.WriteLine(pærerBeholdning.Find(x => x.Lager==20));
            Console.WriteLine();


            Console.WriteLine("Equals glorød");
            //Find alle elementer i listen hvor navn = “Glorød Williams” (brug equals)
            foreach (var item in pærerBeholdning.FindAll(x => x.Navn.Equals("Glorød Williams")))
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine();
            Console.WriteLine("contains re");
            //Find første element i listen hvori der indgår “re” i navnet (brug “.contains()”)
            Console.WriteLine(pærerBeholdning.Find(x => x.Navn.Contains("re")));




            //Varebeholdning af Æbler

            //var æbleBeholdning = new List<Æbler>();
            //æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });



            //var pærerBeholdning = new List<Pærer>();
            //pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });


            //decimal værdiTotalÆbler = FrugtHandler.CalculateSumÆbler(æbleBeholdning);
            //Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            //decimal værdiTotalPærer = FrugtHandler.CalculateSumPærer(pærerBeholdning);
            //Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);


            Console.ReadLine();
        }
    }
}
