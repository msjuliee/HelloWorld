using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    public class RandomNumber
    {
        Random rnd = new Random();
        public float randomNumber()
        {
            float random = rnd.Next(1, 20);
            return random;
        }
    }
}
