using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    class Car
    {
        public const int  MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Apelido do seu carro.</param>
        /// <param name="speed">Velocidade atual do seu carro.</param>
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

            CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
            ex.HelpLink = "http://carsrus.com";

            throw ex;

            
        }
    }
}
