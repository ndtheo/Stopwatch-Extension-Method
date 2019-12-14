using System.Diagnostics;

namespace Helpers
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// This method facilitates the use of <see cref="Stopwatch"/> class, given that it automatically stops the timer, prints the performance measurement results directly to the Output window (milliseconds, ticks), using <see cref="Debug.WriteLine()"/> method.
        /// 
        /// Furthermore, the method can restart the timer if applicable (depending on the restartAfterFinish parameter value).
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="methodPoint"></param>
        /// <param name="restartAfterFinish"></param>
        public static void StopWatchAndWriteLineResults(this Stopwatch timer, string methodPoint, bool restartAfterFinish = false)
        {
            timer.Stop();
            Debug.WriteLine($"{methodPoint} finish ms:{timer.ElapsedMilliseconds} ticks:{timer.ElapsedTicks}");
            if (restartAfterFinish)
            {
                timer.Start();
            }
        }
    }
}
