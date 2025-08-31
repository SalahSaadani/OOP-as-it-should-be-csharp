using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN_C____Method_Overriding_in_C__Inheritance
{
    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi, I'm the print method from the base class A");
        }
    }
    public class clsB : clsA
    {
        public override void Print()

        {
            Console.WriteLine("Hi, I'm the print method from the derived class B");

            base.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of Empoyee
            clsB ObjB = new clsB();

            ObjB.Print();

            Console.ReadKey();
        }
    }
}
