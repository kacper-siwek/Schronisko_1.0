using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchroniskoV2.Business_Logic
{
    public class AnimalsAmountExceededException : Exception
    {
        AnimalsAmountExceededException()
        {
        }

        public AnimalsAmountExceededException(string message) : base(message)
        {
        }
    }
}
