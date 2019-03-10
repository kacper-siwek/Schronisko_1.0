﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    sealed class AnimalRepository
    {
        private static AnimalRepository instance = null;

        public List<Animal> animals;
        private AnimalRepository()
        {
            animals = new List<Animal>();
        }

        public static AnimalRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalRepository();
            }
            return instance;
        }

        public void Add(Animal animal)
        {
            animals.Add(animal);
        }
        public int Count()
        {
            return animals.Count;
        }

        public string ListAnimalsString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var animal in animals)
            {
                stringBuilder.Append(animal.ToString());
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

        public List<Animal> ListAnimalClass()
        {
            return animals;
        }
        
        public void RemoveAnimal(Animal selectedAnimal)
        {
            int index = animals.IndexOf(selectedAnimal);
            animals.RemoveAt(index);
        }

    }
}
