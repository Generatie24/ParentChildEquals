using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuig1 = new Voertuig { Merk = "Toyota" };
            Voertuig voertuig2 = new Voertuig { Merk = "Toyota" };
            Voertuig voertuig3 = new Voertuig { Merk = "Honda" };

            Auto auto1 = new Auto { Merk = "Toyota", Model = "Corolla" };
            Auto auto2 = new Auto { Merk = "Toyota", Model = "Corolla" };
            Auto auto3 = new Auto { Merk = "Toyota", Model = "Camry" };

            Console.WriteLine("Vergelijk voertuig1 met voertuig2: " + voertuig1.Equals(voertuig2)); // True
            Console.WriteLine("Vergelijk voertuig1 met voertuig3: " + voertuig1.Equals(voertuig3)); // False
            Console.WriteLine("Vergelijk voertuig1 met auto1: " + voertuig1.Equals(auto1));       // False

            Console.WriteLine("Vergelijk auto1 met auto2: " + auto1.Equals(auto2));             // True
            Console.WriteLine("Vergelijk auto1 met auto3: " + auto1.Equals(auto3));             // False
            Console.WriteLine("Vergelijk auto1 met voertuig1: " + auto1.Equals(voertuig1));     // False

        }
    }
}
