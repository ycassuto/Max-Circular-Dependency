using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_solution
{
    class A 
    {
        public A()
        {
            SubscribeToEvent();
        }

        public void C()
        {
            B b = new B();
            b.MakeCoffee();
        }

        public void CallEmployees()
        {
            Console.WriteLine("call the employees");
        }

        private void SubscribeToEvent()
        {
            LettersEvents.onCoffeeHalfDone += CallEmployees;
        }
    }

    class B
    {
        public void MakeCoffee()
        {
            //task 1
            //task 2
            Console.WriteLine("half way there");
            LettersEvents.CoffeeHalfDone();
            //task 3
            //task 4
            Console.WriteLine("finish coffee make");
        }
    }

    public static class LettersEvents
    {
        public static event Action onCoffeeHalfDone;
        public static void CoffeeHalfDone()
        {
            if (onCoffeeHalfDone != null)
            {
                onCoffeeHalfDone();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.C();
            Console.ReadLine();
        }
    }
}
