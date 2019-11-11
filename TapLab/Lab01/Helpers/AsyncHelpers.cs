using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TapLab.Lab01.Helpers
{
    class AsyncHelpers
    {
        /// <summary>        
        /// Should wait Asynchronously for given number of seconds 
        /// And return the same input passed in for delay         
        /// Should also accept a cancellation token if the client wishes to cancel
        /// </summary>
        /// <returns> int - same value passed in </returns>

        public static async Task<int> DelayedReturnAsync(int seconds, CancellationToken ct = default)
        {
            // replace below line with actual implementation
            return await Task.FromResult(default(int)); 
        }



        /// <summary>        
        /// Prints passed in value if secondsToCancel is less than time taken for DelayedReturnAsync to return the data
        /// Otherwise, prints TaskCancelled Exception    
        /// </summary>
        /// <returns> int - same value passed in </returns>

        public async Task Test_DelayedReturnAsync(int seconds, int secondsToCancel)
        {
            try
            {
                // replace below line with actual implementation
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
