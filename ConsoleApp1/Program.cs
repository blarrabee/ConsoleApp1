using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("my name is Blaise");

            System.Int32 anyNumber = 10;
            System.String simpleString = "simple string";
            //Console.WriteLine(anyNumber.GetTypeCode);

            //anyNumber = 4;

            Console.WriteLine(anyNumber);
            Thread.Sleep(1000);
            Console.WriteLine("done sleeping");
            Console.WriteLine(simpleString);

        }
    }
}
