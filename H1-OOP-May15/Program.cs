using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_May15
{
    internal class Program
    {
        static void Main()
        {
            Box B4 = new Box(5, 4, 2); //smallBox
            Box C1 = new Box(3, 5, 2); //smallBox
            Box M5 = new Box(6, 2, 3); //mediumBox
            Box N9 = new Box(1, 8, 4); //largeBox

            double B4Volume = GetVolume(B4.Height, B4.Width, B4.Length);
            Console.WriteLine(B4Volume);

            Console.ReadKey();
        }
        public static double GetVolume(double Height, double Width, double Length)
        {
            double Result = Height * Width * Length;
            return (Result);
        }
    }
}


//
//
//
//Regel:
//LilleBox + lilleBox giver mellemBox, resten er storBox.
//Siderne i den nye box skal beregnes, og tildeles det nye objekt, indregn et tab på 5% i de nye værdier
//Box G55 = B4 + C1; // B4(smallBox) + C1(smallBox) = G55(mediumBox) 