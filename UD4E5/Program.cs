using System;

namespace UD4E5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia = "martes";
            switch (dia)
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("Ese dia no es correcto");
                    break;
            }
        }
    }
}   
