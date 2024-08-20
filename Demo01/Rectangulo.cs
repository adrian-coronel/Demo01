using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Rectangulo
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetArea() { return Base * Height; }

        public double GetPerimeter() { return 2 * (Base + Height); }
    }
}
