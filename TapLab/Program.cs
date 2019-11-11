using System;
using System.Threading;
using System.Threading.Tasks;
using TapLab.Lab01;
using TapLab.Lab01.Helpers;

namespace TapLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main Started");

            // Uncomment for testing as needed

            //await AsyncHelpers.Test_DelayedReturnAsync(2, 3); // should succeed
            //await AsyncHelpers.Test_DelayedReturnAsync(2, 1); // should print task cancelled exception


            // await Combinator.FirstComeFirstServe();






            await Task.CompletedTask;
           
            Console.WriteLine("\nMain Completed. Press Enter to Exit\n");
            Console.ReadLine();
        }

        
    }
}
