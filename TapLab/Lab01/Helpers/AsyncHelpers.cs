using System;
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
            await Task.Delay(TimeSpan.FromSeconds(seconds), ct);
            return seconds;
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
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(secondsToCancel));
                var res = await AsyncHelpers.DelayedReturnAsync(seconds, cts.Token);
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
