using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole
{
    public class Exercise
    {
        void ExOne()
        {
            var numbers = new List<int>() { 56, 3, 167, 32, 67, 0, 14, 766, 1238, 321, 92, 18, 15, 432, 29 };
            foreach (var n in numbers)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();

            var selected = numbers.Where(n => n > 100);
            foreach (var n in selected)
            {
                Console.Write($"{n}, ");
            }

            Console.WriteLine();
            var oneElement = numbers.FirstOrDefault(n => n > 6000000);
            Console.WriteLine(oneElement);

            var ordered = numbers.OrderByDescending(n => n);
            foreach (var n in ordered)
            {
                Console.Write($"{n}, ");
            }


            var sum = numbers.Sum();
            Console.WriteLine(sum);
        }




        //public int AddTwoDigits(int a, int b)
        //{
        //    return a + b;
        //}

        //public int DivideTwoDigits(int a, int b)
        //{
        //    return a / b;
        //}

        //public void Test()
        //{
        //    var names = new List<string>();
        //    names.Add("Joanna");
        //    names.Add("Wojtek");
        //    names.Add("Kasia");
        //    names.Add("Tomasz");

        //    var name = names[1];

        //    var howMany = names.Count;
        //}

        public void TestPetli()
        {
            //for (int index = 0; index < 3; index++)
            //{
            //    Console.WriteLine(index);
            //}

            //var names = new List<string>();
            //names.Add("Joanna");
            //names.Add("Wojtek");
            //names.Add("Kasia");
            //names.Add("Tomasz");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


        }

        public void TestIfa()
        {
            var x = 11;
            if (x == 10)
            {
                Console.WriteLine(10);
            }
            else
            {
                Console.WriteLine("Nie 10");
            }
        }

        public void Operatory()
        {
            //int z = 2; // operator przypisania
            //var t = 5 / z; //
            //var o = z * 4;
            //var m = 5 / z;
            //var k = z % 2;

            ////if (z == 10) // operator porównania
            ////if (z != 5)
            //if (m == 10 && t == 5)
        }

    }
}
