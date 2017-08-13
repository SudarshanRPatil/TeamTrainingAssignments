using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World, Current date time is {0}", DateTime.Now);
            System.Console.WriteLine("parameter count = {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
			System.Console.ReadKey();
        }
    }
}