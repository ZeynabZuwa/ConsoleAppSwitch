using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            // Man har en array och man vill göra den större

            double[] MyArray = { 2.5, 1.9, 0.9 };

            // Lägg till värdet 22.34

            double[] TempArray = new double[MyArray.Length + 1];

            //Nu har vi skrivit över vår MyArray med TempArray värden
            for (int i = 0; i < MyArray.Length; i++)
            {
                TempArray[i] = MyArray[i];
            }

            TempArray[TempArray.Length - 1] = 22.34;
            MyArray = TempArray;

            Console.WriteLine(MyArray[MyArray.Length - 1]);

            // För att skriva ut hela aaray så måste vi loopa den

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            // Vi skapar en metod som gör detta, så då är det bara att anropa metoden 
            // varje gång vi vill göra detta 





            Console.ReadLine();
        }

    }
}
