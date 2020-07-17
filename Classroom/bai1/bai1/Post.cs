using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    public class Post : IPost
    {
        private int Id;
        private string Title;
        private string Content;
        private string Author;
        private float AverageRate;
        public const int MinRating = 1;
        public const int MaxRating = 5;
        private const int Count = 3;
        public int[] Rates = new int[Count];

        public int Id1 { get => Id; set => Id = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Content1 { get => Content; set => Content = value; }
        public string Author1 { get => Author; set => Author = value; }
        public float AverageRate1 { get => AverageRate; private set => AverageRate = value; }

        public void CalculatorRate()
        {
            float total = 0;
            foreach (var rate in Rates)
            {
                total += rate;
            }
            AverageRate = (float)Math.Round(total / Rates.Length, 0);
        }

        public void Display()
        {
            CalculatorRate();
            Console.WriteLine($"ID: {Id}, Tittle: {Title}, Content: {Content}, Author: {Author}, NumberofRate: {Count}, AvegareRate: {AverageRate}");
        }
    }
}
