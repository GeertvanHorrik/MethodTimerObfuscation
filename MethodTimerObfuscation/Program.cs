namespace MethodTimerObfuscation
{
    using System;
    using System.Threading.Tasks;
    using MethodTimer;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DONE!");
        }

        [Time]
        static void Method()
        {

        }

        [Time]
        static async Task MethodAsync()
        {

        }
    }
}
