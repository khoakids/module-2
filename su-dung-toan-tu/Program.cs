using System;

namespace su_dung_toan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.WriteLine("Enter Width: ");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is " + area);
        }
    }
}
