using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortableDevices
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("RUN NEW APP");
            System.Threading.Thread.Sleep(1000);
            
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = args[0];
            process.Start();

        }
    }
}
