using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_solution
{
    interface ICall
    { 
        void CallEmployees();
    }

    class A : ICall
    {
        public void C()
        {
            B b = new B();
            b.MakeCoffee(this);
        }

        public void CallEmployees()
        {
            Console.WriteLine("call the employees");
        }
    }

    class B
    {
        public void MakeCoffee(ICall caller)
        {
            //task 1
            //task 2
            Console.WriteLine("half way there");
            caller.CallEmployees();
            //task 3
            //task 4
            Console.WriteLine("finish coffee make");
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

