﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumerator
{
    class Car
    {
        public const int  MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CranckTunes(bool state)
        {
            theMusicBox.TurnOn(state);
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
    }
}
