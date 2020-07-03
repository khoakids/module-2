using System;

namespace vd
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = 1;
           int index = 1;
           do {
               for (int i = 0 ; i < 6 ; i++) {
                   index = i;
                   total += index;
               }
           } while (index < 5);
           {
               Console.WriteLine(total);
           }
        }
    }
}
