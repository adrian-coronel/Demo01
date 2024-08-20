using System.Formats.Asn1;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo rectangulo = new Rectangulo();
            //rectangulo.Base = 100;
            //rectangulo.Height = 200;

            //double area = rectangulo.GetArea();
            //double perimeter = rectangulo.GetPerimeter();

            //Console.WriteLine($"El área es {area}");
            //Console.WriteLine($"El perímetro es {perimeter}");

            //////

            //Person persona = new Person();    
            //persona.Firstname = "Adrian";
            //persona.FatherLastname = "Coronel";
            //persona.MotherLastname = "Mendoza";
            //persona.GetFullname();


            /////  

            //Teacher teacher = new Teacher
            //{
            //    Firstname = persona.Firstname,
            //    FatherLastname = persona.FatherLastname,
            //    Salary = 2000,
            //};


            Rectangulo rectangulo = new Rectangulo
            {
                TopLeft = new Coordenadas { X = 0.0, Y = 8.0 },
                TopRigth = new Coordenadas { X = 4.0, Y = 8.0 },
                ButtomRigth = new Coordenadas { X = 0.0, Y = 0.0 },
                ButtonLeft = new Coordenadas { X = 4.0, Y = 0.0 },
            };

            Console.WriteLine($"El área es {rectangulo.GetArea()}");
            Console.WriteLine($"El perímetro es {rectangulo.GetPerimeter()}");
        }
    }
}