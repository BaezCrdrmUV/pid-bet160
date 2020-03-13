using System;
using System.Diagnostics;

namespace PidDeProceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proceso = Process.GetCurrentProcess();
            Console.WriteLine(proceso.Id);
            Console.ReadLine();
        }
    }
}
