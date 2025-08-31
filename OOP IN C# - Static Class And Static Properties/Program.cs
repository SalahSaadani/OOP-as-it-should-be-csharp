using System;

namespace OOP_IN_C____Static_Class_And_Static_Properties
{
    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            //
            // Read the static properties.
            //
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            //
            // Change the value of the static bool property.
            //
            Settings.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings.ProjectPath);
            Console.ReadKey();

        }
    }
}
