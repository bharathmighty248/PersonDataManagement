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
                "\n3. Retrieve Top 2 Persons Below Age 60 " +
                "\n4. Retrieve All Data Between Age 13 To 18 " +
                "\n5. Retrieve Average Age " +
                "\n6. Specific Name Check " +
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
                    case 4:
                        personDataMain.RetrieveAllDataBetweenAge13To18(list);
                        break;
                    case 5:
                        personDataMain.RetrieveAverageAge(list);
                        break;
                    case 6:
                        personDataMain.SpecificNameCheck(list);
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
