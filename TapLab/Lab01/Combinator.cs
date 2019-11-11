using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapLab.Lab01.Helpers;

namespace TapLab.Lab01
{
    
    class Combinator
    {
        // For Further Reading, see: https://blog.stephencleary.com/2012/02/async-and-await.html

        /// <summary>
        /// At the moment, below method prints 2, 3, 1 (values returned from each of those tasks)
        /// This is despite TaskC getting completed ahead of TaskA and TaskB
        /// We want it to print 1, 2, 3 (while keeping task creation setup as it is)
        /// </summary>
        /// <returns>Print 1, 2, 3</returns>

        public static async Task FirstComeFirstServe()
        {
            // Create a sequence of tasks.
            Task<int> taskA = AsyncHelpers.DelayedReturnAsync(2);
            Task<int> taskB = AsyncHelpers.DelayedReturnAsync(3);
            Task<int> taskC = AsyncHelpers.DelayedReturnAsync(1);
            Task<int>[] tasks = new[] { taskA, taskB, taskC };

            // Await each task in order.   
            // Below logic will need to be replaced / changed to get the intended result
            foreach (Task<int> task in tasks)
            {
                await AwaitAndProcessAsync(task);
            }
        }

        static async Task AwaitAndProcessAsync(Task<int> task)
        {
            int result = await task;
            Console.WriteLine(result);
        }
    }
}
