using System;

namespace _20_so_nguyen_to_dau_tien
{
    class Program
    {

        static void Main(string[] args)
        {
            

            // NewClass class1 = new NewClass("Class1");

            // var class1Name = class1.GetClassName();

            // var nameOfNewClass = NewClass.GetNameOfClass();

            // Console.WriteLine(class1Name);

            // int[] a = new int[1];
            // a[0] = 1;
            // int[] b = new int[1];
            // b[0] = 2;


            // int soTien = 5000000;

            // Console.WriteLine(Test.Num2Text(soTien.ToString()));

            // Console.WriteLine($"{a[0]} {b[0]}");
            // NewClass.Swap(a, b);
            // Console.Write($"{a[0]} {b[0]}");

            Console.WriteLine("enter the total of prime numbers: ");
            int total = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 3; count < total; i++)
            {
                bool check = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
            {
                Console.WriteLine(i);
                count++;
            }
            }
        }
    }
}