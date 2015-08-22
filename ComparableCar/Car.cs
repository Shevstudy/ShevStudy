using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }

        public string PetName { get; set; }

        private bool carIsDead;

        public int CarId { get; set; }

        public static IComparer SortByPetName
        {
            get { return (IComparer)new PetNameComparer(); }
        }

        //private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed, int id)
        {
            PetName = name;
            CurrentSpeed = speed;
            CarId = id;
        }

        public void CranckTunes(bool state)
        {
            //theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;

                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                    Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://google.com";

                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot!");

                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> currentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;

            if (temp != null)
            {
                return this.CarId.CompareTo(temp.CarId);
            }
            else 
            { 
                throw new ArgumentException("Parameter is not a Car!"); 
            }
        }
    }
}
