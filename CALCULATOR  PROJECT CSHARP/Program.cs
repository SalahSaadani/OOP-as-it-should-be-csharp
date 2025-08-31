using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR__PROJECT_CSHARP
{
    class clsCalculator
    {
        private float Result = 0;
        private float LastNumber = 0;
        private string LastOperation = "Clear";
        private bool IsZero(float Number)
        { 
            return (Number == 0);
        }
       public void Add(float Number)
        { 
            LastNumber = Number;
            LastOperation = "Adding";
            Result += Number;
        }
        public void PrintResult()
        {
            Console.WriteLine($"Result After {LastOperation} {LastNumber} is: {Result}");
        }
        public void Clear() 
        { 
            LastNumber = 0; 
            LastOperation = "Clear";
            Result = 0;
        }

        public void Subtract(float Number)
        { 
            LastNumber = Number;
            LastOperation = "Subtracting";
            Result -= Number;
        }

        public bool Divide(float Number)
        {
            bool Succeeded = true;
            LastOperation = "Dividing";

            if (IsZero(Number))
            {
                LastNumber = Number;
                Result /= 1;
                Succeeded = true;
            }
            else
            {
                LastNumber = Number;
                Result /= Number;
            }

            return Succeeded;
        }

       public void Multiply(float Number)
        { 
            LastNumber = Number;
            LastOperation = "Multiplying";
            Result *= Number;
        }

        public float GetFinalResults()
        {
            return Result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator() ;

            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();
        }
    }
}
