using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    public class Animal : AnimalClass
    {
        public static int animalId = 1;
        
        private DateTime _dateOfAdmission;

        public DateTime DateOfAdmission
        {
            get { return _dateOfAdmission; }
            private set { _dateOfAdmission = value; }
        }
        
        public Animal(string name, string type)
        {
            this.AnimalId = animalId++;
            this.Name = name;
            this.Type = type;
            this.DateOfAdmission = DateTime.Now;
        }

        public Animal(int Id, string name, string type, DateTime dateOfAdmission)
        {
            // this constructor is meant to be used only with the CSVReaderWriter, in order to instantiate the Animal objects after starting the program.

            this.AnimalId = Id;
            this.Name = name;
            this.Type = type;
            this.DateOfAdmission = dateOfAdmission;

            animalId = ++Id;
        }

        public override string ToString()
        {
            return $"{this.AnimalId} - {this.Type} - {this.Name}. Przyjęty {this.DateOfAdmission}";
        }
    }
}
