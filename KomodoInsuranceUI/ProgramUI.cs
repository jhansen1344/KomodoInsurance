using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceUI
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {

            bool keepRunning = true;

            while (keepRunning)
            {


                string menu = "Select a menu option:\n" +
                    "1. Create New Developer\n" +
                    "2. View Developers\n" +
                    "3. View Developer By Name\n" +
                    "4. Update Developer\n" +
                    "5. Delete Developer\n" +
                    "6. Create New Team\n" +
                    "7. View Teams\n" +
                    "8. View Team By Name\n" +
                    "9. Update Team\n" +
                    "10. Delete Team\n" +
                    "11. Exit\n";

                Console.WriteLine(menu);

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Menu Option");
                        break;
                }
            }


        }
    }
}
