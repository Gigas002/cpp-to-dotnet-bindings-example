using System;
using MathLibrary.NET.Core;

namespace MathLibrary.NET.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Api.Test(5);
            Console.WriteLine($"Result={num}");
            Console.ReadKey();
        }
    }
}
