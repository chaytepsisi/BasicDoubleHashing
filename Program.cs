using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace BasicDoubleHashing
{
    class Program
    {
        static void computehash()
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();
            int counter = 0;
            int hashCounter = 0;
            int max = 0;

            for (int i = 0; i < 10; i++)
            {
                stp.Restart();
                while (stp.ElapsedMilliseconds < 60000)
                {
                    string hashValue = Crypto.doubleSha256((hashCounter++).ToString());
                    counter = 0;
                    while (hashValue[0] == '0')
                    {
                        hashValue = hashValue.Substring(1);
                        counter++;
                    }
                    if (counter > max)
                        max = counter;
                }
                Console.WriteLine(max);
            }

        }
        static void Main(string[] args)
        {
            computehash();
        }
    }
}
