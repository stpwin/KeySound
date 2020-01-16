using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeySound
{
    public static class Helpers
    {
        public static void WaitUntilTimeoutWhileTrue(Func<bool> condition, int timeoutMs)
        {
            int startTime = Environment.TickCount;
            while (Environment.TickCount - startTime < timeoutMs && condition.Invoke())
            {
            }
        }
    }
}
