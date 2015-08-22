using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //Estado de Car
        public string petName;
        public int currSpeed;

        //Construtor padrão personalizado.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //Aqui, currSpeed receberá um valor padrão de um int(zero);
        public Car(string pn)
        {
            petName = pn;
        }


        //Deixe que o solicitate defina o estado completo de Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        //Funcionalidade de Car
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH...", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
