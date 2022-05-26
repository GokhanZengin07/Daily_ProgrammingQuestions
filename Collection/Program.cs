using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var salmons = new List<string>();
            salmons.Add("asd");
            salmons.Add("qwe");
            salmons.Add("rty");
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon);
            }

            var salmons2 = new List<string> { "chin", "coho", "pink" };
            for (int i = 0; i < salmons2.Count; i++)
            {
                Console.WriteLine(salmons2[i]);
            }

            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            new Galaxy() { Name="Milky Way", MegaLightYears=0},
            new Galaxy() { Name="Andromeda", MegaLightYears=3}
        };
        }

        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
