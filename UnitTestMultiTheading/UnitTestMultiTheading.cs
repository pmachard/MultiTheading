using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Linq;

namespace UnitTestMultiTheading
{
    [TestClass]
    public class UnitTestMultiTheading
    {
        private Thread myThread;
        static int cpt = 0;

        [TestMethod]
        public void TestMethod1()
        {
            myThread = new Thread(new ThreadStart(ThreadLoop));
            myThread.Start();
            while (cpt < 10)
            {

            }
        }

        public static void ThreadLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(500);
                cpt++;
                Console.WriteLine("Je travaille...");
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = string.Join(" ", array);
        }

    }

    interface IA
    {
        void fct();
    }

    class A : IA
    {
        public void fct() { }
    }

    class B : A
    {
    }

    class C : A
    {
    }
}
