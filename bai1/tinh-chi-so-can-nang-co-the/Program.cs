using System;

namespace tinh_chi_so_can_nang_co_the
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            Console.WriteLine("enter a height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);
            Console.WriteLine();
            if (bmi < 18)
            {
                Console.WriteLine("Underweight");
            }
            else if(bmi < 25.0)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
    }
}
