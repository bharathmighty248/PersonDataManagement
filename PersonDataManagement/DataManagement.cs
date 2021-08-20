using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class DataManagement
    {
        public void Manage()
        {
            int choice;
            List<Person> list = new List<Person>();
            PersonDataMain personDataMain = new PersonDataMain();
            do
            {
                Console.Write("\n1. Add Person Data " +
                "\n2. Display Data " +
                "\n3. Retrive Top 2 Persons Below Age 60 " +
                "\n0. Exit " +
                "\nPlease Select Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        personDataMain.AddPersonData(list);
                        break;
                    case 2:
                        personDataMain.DisplayData(list);
                        break;
                    case 3:
                        personDataMain.RetrieveTop2BelowAge60(list);
                        break;
                    case 0:
                        Console.WriteLine("Thankyou..");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
