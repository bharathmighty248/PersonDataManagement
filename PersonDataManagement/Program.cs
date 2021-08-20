using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            DataManagement dataManagement = new DataManagement();
            dataManagement.Manage();
        }
    }
}
