using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Person
    {
        public string Firstname { get; set; }
        public string FatherLastname { get; set; }
        public string MotherLastname { get; set; }

        public void GetFullname()
        {
            Console.WriteLine($"{Firstname} {FatherLastname} {MotherLastname}");
        }
    }
}
