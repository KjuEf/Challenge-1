using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1
             Console.WriteLine("Write a number from 1 to 10.");
             var broj = Convert.ToInt16(Console.ReadLine());

             if (broj >= 1 && broj <= 10)
             {
                 Console.WriteLine("Valid");
             }
             else
             {
                 Console.WriteLine("Not Valid");
             }

             // Challenge 2
             Console.WriteLine("Write two numbers");
             var broj2 = Convert.ToInt16(Console.ReadLine());
             var broj3 = Convert.ToInt16(Console.ReadLine());

             if (broj2 > broj3)
             {
                 Console.WriteLine("The " + broj2 + " number is bigger");
             }
             else if (broj2 < broj3)
             {
                 Console.WriteLine("The " + broj3 + " number is bigger");
             }
             else
             {
                 Console.WriteLine("The two numbers are equal");
             }

             // Challenge 3
             Console.WriteLine("Write height and width of image:");
             var height = Convert.ToDouble(Console.ReadLine());
             var width = Convert.ToDouble(Console.ReadLine());

             if (height > width)
             {
                 Console.WriteLine("The image is landscape");
             }
             else if (height < width)
             {
                 Console.WriteLine("The image is portrait");
             }
             else
             {
                 Console.WriteLine("The image is kocka");
             }

            // Challenge 4
            Console.WriteLine("Enter the speed limit:");
            var Limit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the speed of vehicle:");
            var Speed = Convert.ToInt64(Console.ReadLine());

            if(Speed > Limit)
            {
                var demirit = (Speed - Limit) / 5;
                if(demirit < 12)
                {
                    Console.WriteLine(demirit);
                }
                else
                {
                    Console.WriteLine("You cant drive anymore!");
                }
            }
            else
            {
                Console.WriteLine("OK");
            }

        }
    }
}
