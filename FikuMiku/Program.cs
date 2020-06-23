using System;
using System.Linq;

namespace FikuMiku
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList()
                .ForEach(x =>
                {
                    Console.WriteLine("{0}{1}{2}",
                        x % 3 == 0 ? "Fiku" : "",
                        x % 5 == 0 ? "Miku" : "",
                        x % 5 != 0 && x % 3 != 0 ? x.ToString() : "");
                });
        }
    }
}