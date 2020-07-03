using System;

namespace _20_so_nguyen_to_dau_tien
{
    public class NewClass
    {
        static void Main() {
            Console.WriteLine("From New Class");
        }

        public string ClassName;

        public NewClass(string ClassName) {
            this.ClassName = ClassName;
        }

        public string GetClassName() {
            return ClassName;
        }

        public static string GetNameOfClass() {
            return "NewClass";
        }

        public static void Swap(int[] a, int[] b) {
            int temp = b[0];
            b[0] = a[0];
            a[0] = temp;
        }
    }
}