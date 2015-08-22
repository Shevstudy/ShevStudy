using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYeld
{
    public class Garage
    {
        private Car[] carrArray = new Car[4];

        public Garage()
        {
            carrArray[0] = new Car("Rusty", 30);
            carrArray[1] = new Car("Clunker", 55);
            carrArray[2] = new Car("Zippy", 30);
            carrArray[3] = new Car("Fred", 30);
        }



        public IEnumerator GetEnumerator()
        {
            foreach (Car c in carrArray)
            {
                yield return c;
            }
        }

        public IEnumerable GetTheCars(bool ReturnReversed)
        {
            if (ReturnReversed)
            {
                for (int i = carrArray.Length; i != 0; i--)
                {
                    yield return carrArray[i - 1];
                }
            }
            else
            {
                foreach (Car c in carrArray)
                {
                    yield return c;
                }
            }
        }
    }
}
