using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RT_assignment
{
    class Program
    {
        public static string Name = "Morten Hafreda";
        public static int StudentNumber = 120426;
        public static int SemesterYear = 2017;
        public static Semaphore semName;
        public static Semaphore semNumber;
        public static Semaphore semYear;

        static void Main(string[] args)
        {
            Console.WriteLine("Program starting:");
            semName = new Semaphore(1, 1);
            semNumber = new Semaphore(1, 1);
            semYear = new Semaphore(1, 1);
            ThreadClass Task1 = new ThreadClass("Task1", 95);
            ThreadClass Task2 = new ThreadClass("Task2", 208);
            ThreadClass Task3 = new ThreadClass("Task3", 321);
            ThreadClass Task4 = new ThreadClass("Task4", 434);
            ThreadClass Task5 = new ThreadClass("Task5", 547);
            for (int seconds = 0; seconds < 30; seconds++)
            {
                Console.WriteLine("0." + seconds.ToString());
                Thread.Sleep(100);
            }
            Console.Read();
        }
    }
    class ThreadClass
    {
        int countLoop;
        int delay;
        Thread taskThread;
        public ThreadClass(string Name, int Delay)
        {
            countLoop = 0;
            delay = Delay;
            taskThread = new Thread(new ThreadStart(this.run));
            taskThread.Name = Name;
            taskThread.Start();
            
        } 

        private void run()
        {
            do
            {
                countLoop++;
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " is waiting for the resources to be free");
                Program.semName.WaitOne();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has accessed Name");
                Program.semNumber.WaitOne();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has accessed Student Number");
                Program.semYear.WaitOne();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has accessed Semester Year");
                Thread.Sleep(50);
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + ": " + Program.Name + " " + Program.StudentNumber.ToString() + " " + Program.SemesterYear.ToString());
                Program.semYear.Release();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has released Semester Year");
                Program.semNumber.Release();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has released Student Number");
                Program.semName.Release();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " " + taskThread.Name + " has released Name");
                Thread.Sleep(delay);
            } while (countLoop < 5);
        }


    }
}
