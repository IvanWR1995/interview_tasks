using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
     class SecondTask
    {
        public static void Run()
        {
            var pingSemaphore = new SemaphoreSlim(1, 1);
            var pongSemaphore = new SemaphoreSlim(0, 1);
            var pingTask = Task.Run(() =>
            {
                while (true)
                {
                    pingSemaphore.Wait();
                    Console.WriteLine("ping");
                    pongSemaphore.Release();
                }
            });
            var pongTask = Task.Run(() =>
            {
                while (true)
                {
                    pongSemaphore.Wait();
                    Console.WriteLine("pong");
                    pingSemaphore.Release();
                }
            });

            Task.WaitAll(pingTask, pongTask);

        }
    }
}
