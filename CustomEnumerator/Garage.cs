using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    public class Garage: IEnumerable
    {
        private Car[] carrArray = new Car[4];

        public Garage()
        {
            carrArray[0] = new Car("Rusty", 30);
            carrArray[1] = new Car("Clunker", 55);
            carrArray[2] = new Car("Zippy", 30);
            carrArray[3] = new Car("Fred", 30);
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return carrArray.GetEnumerator();
        }

        
    }
}
