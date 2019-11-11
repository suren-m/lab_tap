using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TapLab.Lab02
{
    class Compute
    {
        public static ConcurrentDictionary<int, ulong> ComputeSquareParallel(int start, int count)
        {
            throw new NotImplementedException();            
        }

        public static Dictionary<int, ulong> ComputeSquare(int start, int count)
        {
            var res = new Dictionary<int, ulong>();
            foreach (var i in Enumerable.Range(start, count))
            {
                var square = (ulong)(i * i);

                Console.WriteLine($"Square of {i} is {square}. Processed by Thread - {Thread.CurrentThread.ManagedThreadId}");

                res.Add(i, square);
            }

            return res;
        }

    }
}
