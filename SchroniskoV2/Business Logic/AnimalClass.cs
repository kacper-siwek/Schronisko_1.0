using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    public abstract class AnimalClass
    {
        public int AnimalId { get; protected set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
