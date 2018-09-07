using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a farm
            Mouse Cheryll = new Mouse();
            Chicken Martha = new Chicken();
            Goat Spot = new Goat();
            Sheep Beatrice = new Sheep();

            Console.WriteLine("Hello and welcome to my farm!");
            Console.WriteLine("Let me introduce you to our animals");
            Console.WriteLine();

            //Call the animals
            Cheryll.speak();
            Martha.speak();
            Spot.speak();
            Beatrice.speak();
            Console.ReadLine();

        }
    }
}
