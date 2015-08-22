using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class Point: ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;            
        }
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2}; \nID = {3}\n", X, Y, desc.PetName, desc.PointId);
        }

        public object Clone()
        {
            //return new Point(this.X, this.Y);
            //return this.MemberwiseClone();

            Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();

            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;

            return newPoint;
        }
    }
}
