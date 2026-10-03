using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {   float bedSettings;
            int lenght,width;
            Console.WriteLine("Enter the bed settings cm: ");
            lenght = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("Enter the width cm: ");
            width = Convert.ToInt16(Console.ReadLine());
            bedSettings= (lenght * width);
            bedSettings = bedSettings / 10000;
            Console.WriteLine("The bed settings is m^2: " + bedSettings);

            if (bedSettings < 1.55)
            {
                Console.WriteLine("The bed settings is less than 1.55 m^2 so prize is 1000");
            }
            else if (bedSettings >= 1.55 && bedSettings <= 5)
            {
                Console.WriteLine("The bed settings is between 1.55 and 5 m^2 so prize is 2000");
            }
            else
            {
                Console.WriteLine("The bed settings is more than 5 m^2 so prize is 3000");
            }
        }
    }
}
