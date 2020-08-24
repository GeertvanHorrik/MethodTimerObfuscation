using System;

namespace MethodTimerObfuscation
{
    class Program
    {
        static async void Main(string[] args)
        {
            Method();

            await MethodAsync();

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
