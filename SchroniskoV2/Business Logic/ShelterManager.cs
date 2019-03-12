using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    public static class ShelterManager
    {
        // Shelter properties
        public static readonly int LimitZwierzat = 5;


        #region Adding and removing animals
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
        public static void Add(int Id, string name, string type, DateTime dateTime)
        {
            var animalRepository = AnimalRepository.GetInstance();
            if (animalRepository.Count() < LimitZwierzat)
            {
                animalRepository.Add(new Animal(Id, name, type, dateTime));
            }
            else
            {
                throw new AnimalsAmountExceededException("Dodano za dużo zwierząt");
            }
        }
        public static void RemoveAnimal(Animal animal)
        {
            var animalRepository = AnimalRepository.GetInstance();
            animalRepository.RemoveAnimal(animal);
        }
        #endregion

        #region Listing and counting animals
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

        public static ObservableCollection<Animal> ListAnimals()
        {
            var animalRepository = AnimalRepository.GetInstance();
            return animalRepository.ListAnimalClass();
        }
        #endregion


        #region Saving and reading animals
        public static void SaveShelterStatus(bool isExiting)
        {
            CSVReaderWriter.SaveShelterStatus(isExiting);
        }

        public static void LoadShelterStatus()
        {
            CSVReaderWriter.LoadShelterStatus();
        }
        #endregion

    }
}
