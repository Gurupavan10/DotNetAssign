using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class TheedingTasks
    {
        public void DisplayCLock()
        {

            Console.WriteLine(System.DateTime.Now.ToString());

        }
        public void DisplaySeconds()
        {

            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString("hh mm ss"));
                //Task.Delay(1000).Wait();
                Thread.Sleep(1000);
            }



        }
        static void Main()
        {
            TheedingTasks theedingTasks = new TheedingTasks();
            theedingTasks.DisplayCLock();

            theedingTasks.DisplaySeconds();
            Console.ReadLine();
        }
    }
}