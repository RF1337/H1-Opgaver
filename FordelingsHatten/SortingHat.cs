using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordelingsHatten
{
    internal class SortingHat
    {
        public enum Hats
        {
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }

        private Random random = new Random();

        public Enum RandomizeHat()
        {
            return (Hats)random.Next(1, 4);
        }
    }
}
