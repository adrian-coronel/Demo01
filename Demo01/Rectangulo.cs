using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Rectangulo
    {
        public Coordenadas TopRigth { get; set; }
        public Coordenadas TopLeft { get; set; }
        public Coordenadas ButtomRigth { get; set; }
        public Coordenadas ButtonLeft { get; set; }


        public double GetArea() { 
            return GetBase() * GetAltura();
        }
        public double GetPerimeter()
        {
            return (GetBase() + GetAltura()) * 2;
        }


        public double GetBase()
        {
            return GetDistance(ButtonLeft, ButtomRigth);
        }
        public double GetAltura()
        {
            return GetDistance(TopRigth, ButtomRigth);
        }
        private double GetDistance(Coordenadas coord1, Coordenadas coord2)
        {
            return Math.Sqrt(Math.Pow(coord2.X - coord1.X, 2) + Math.Pow(coord2.Y - coord1.Y, 2));
        }

    }


    public class Coordenadas
    {
        public double Y { get; set; }
        public double X { get; set; }
    }
}
