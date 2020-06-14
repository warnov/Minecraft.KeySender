using System;
using System.Threading;

namespace Minecraft.KeySender
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandTemplate = "/fill {0} {1} {2} {3} {4} {5} {6} sandstone_stairs 2";
            Console.WriteLine("Hello World!");
            //            344 63  112 294 63  112
            //            343 64  113 295 64  113
            int x1=343, y1=64, z1=113, x2=295, y2=64, z2=113;
            for (int i = 0; i < 10; i++)
            {
                x1--;
                y1++;
                z1++;
                x2--;
                y2++;
                z2++;
                var command = String.Format(commandTemplate, x1, y1, z1, x2, y2, z2);

                Thread.Sleep(5000);
            }

        }
    }
}
