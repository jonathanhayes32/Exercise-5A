﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5A
{
    public class Goat
    {
        public string name;
        public string noise;
        public string food;
        public string species;

        public Goat()
        {
            name = "Spot";
            noise = "ehh ehh ehh!";
            food = "Grass";
            species = "Goat";
        }
        public void AssignName(string newName)
        {
            name = newName;
        }
        public void makeNoise(string newNoise)
        {
            noise = newNoise;
        }
        public void Eats(string newFood)
        {
            food = newFood;
        }
        public void Species(string newSpecies)
        {
            species = newSpecies;
        }

        public void speak()
        {
            Console.WriteLine("This is a {0} named: {1}", species, name);
            Console.WriteLine("eats: {0}", food);
            Console.WriteLine("says: {0}", noise);
        }
    }
      
    }

