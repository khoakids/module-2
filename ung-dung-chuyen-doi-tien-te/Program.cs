using System;

namespace ung_dung_chuyen_doi_tien_te
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rate = 23000;
            Console.WriteLine("Enter your money need transfer: ");
            int money = Convert.ToInt32(Console.ReadLine());
            int result;
            result = money * rate;
            Console.WriteLine("Result is: " + result);
        }
    }
}
