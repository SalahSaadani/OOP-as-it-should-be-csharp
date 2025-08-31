using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN_C____Partial_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //the code of MyClass is seperated in 2 files class1.cs and class2.cs
            Class1 obj = new Class1();
            obj.Method1();
            obj.Method2();

            Console.ReadKey();
        }
    }
}
