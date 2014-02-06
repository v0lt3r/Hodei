using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point3d
    {
        private double x;
        private double y;
        private double z;
        private string var;

        public Point3d()
        {
            SetX(0);
            SetY(0);
            SetZ(0);
        }
        public Point3d(double x, double y, double z)
        {
            SetX(this.x);
            SetY(this.y);
            SetZ(this.z);
        }
        public void MoveTo(double x, double y, double z)
        {
            SetX(this.x);
            SetY(this.y);
            SetZ(this.z);
        }
        public double DistanceTo(Point3d segundo)
        {
            return Math.Sqrt( Math.Pow(x - segundo.GetX(),2) + Math.Pow(y - segundo.GetY(),2) + Math.Pow(z - segundo.GetZ(),2) );
        }
        public string ToString()
        {
            var = "(" + x + "," + y + "," + z + ")";
            return var;
        }

        private void SetX(double newvalueX)
        {
            x = newvalueX;
        }

        private void SetY(double newvalueY)
        {
            y = newvalueY;
        }

        private void SetZ(double newvalueZ)
        {
            z = newvalueZ;
        }

        private double GetX()
        {
            return x;
        }

        private double GetY()
        {
            return y;
        }

        private double GetZ()
        {
            return z;
        }

    }
}
