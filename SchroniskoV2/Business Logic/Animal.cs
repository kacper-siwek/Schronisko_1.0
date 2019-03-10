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
            Name = name;
            Type = type;
            DateOfAdmission = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this.AnimalId} - {this.Type} - {this.Name}. Przyjęty {this.DateOfAdmission}";
        }
    }
}
