using System.Formats.Asn1;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 100;
            rectangulo.Height = 200;

            double area = rectangulo.GetArea();
            double perimeter = rectangulo.GetPerimeter();

            Console.WriteLine($"El área es {area}");
            Console.WriteLine($"El perímetro es {perimeter}");

            ////
            
            Person persona = new Person();    
            persona.Firstname = "Adrian";
            persona.FatherLastname = "Coronel";
            persona.MotherLastname = "Mendoza";
            persona.GetFullname();
        }
    }
}