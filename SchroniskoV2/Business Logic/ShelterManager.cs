using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    public static class ShelterManager
    {
        public static readonly int LimitZwierzat = 5;
        public static void Add(string name, string type)
        {
            var animalRepository = AnimalRepository.GetInstance();
            if (animalRepository.Count() < LimitZwierzat)
            {
                animalRepository.Add(new Animal(name, type));
            }
            else
            {
                throw new AnimalsAmountExceededException("Dodano za dużo zwierząt");
            }
        }
        public static int Count()
        {
            var animalRepository = AnimalRepository.GetInstance();
            return animalRepository.Count();
        }

        public static string ListAnimalsString()
        {
            var animalRepository = AnimalRepository.GetInstance();
            return animalRepository.ListAnimalsString();
        }

        public static List<Animal> ListAnimals()
        {
            var animalRepository = AnimalRepository.GetInstance();
            return animalRepository.ListAnimalClass();
        }

        public static void RemoveAnimal(Animal animal)
        {
            var animalRepository = AnimalRepository.GetInstance();
            animalRepository.RemoveAnimal(animal);
        }

        public static void SaveAllAnimals(bool isExiting)
        {
            CSVReaderWriter.WriteAllAnimals(isExiting);
        }
    }
}
