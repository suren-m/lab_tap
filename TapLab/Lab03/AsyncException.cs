using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapLab.Lab01.Helpers;

namespace TapLab.Lab03
{
    public class AsyncException
    {
        /// <summary>
        /// At the moment, exceptions from this method will not be captured.
        /// Update the signature and make necessary updates to make sure exceptions are caught.
        /// </summary>
        public static async void DivideByZeroAsync()
        {
            try
            {
                Console.WriteLine("Entering DivideByZeroAsyc");

                var task = Task.Run(async () =>
                {
                    Console.WriteLine("Entering Task");
                    await Task.FromException<DivideByZeroException>(new DivideByZeroException());
                }).ConfigureAwait(false);                

                Console.WriteLine("Exiting DivideByZeroAsyc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Divide by Exception thrown from DivideByZeroAsync");
                throw ex;               
            }
        }      

    }
}
