using KomodoInsuranceClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceUI
{
    public class ProgramUI
    {
        private DeveloperRepo _devRepo = new DeveloperRepo();
        private DevTeamRepo _teamRepo = new DevTeamRepo();
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
                        CreateDeveloper();
                        break;
                    case "2":
                        ViewDevelopers();
                        break;
                    case "3":
                        ViewDeveloperByName();
                        break;
                    case "4":
                        UpdateDeveloper();
                        break;
                    case "5":
                        DeleteDeveloper();
                        break;
                    case "6":
                        CreateTeam();
                        break;
                    case "7":
                        ViewTeams();
                        break;
                    case "8":
                        ViewTeamByName();
                        break;
                    case "9":
                        UpdateTeam();
                        break;
                    case "10":
                        DeleteTeam();
                        break;
                    case "11":
                        Console.WriteLine("GoodBye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Menu Option");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }


        }

        private void CreateDeveloper()
        {
            string name = GetAndValidateInput("Please enter the developer's full name");
            bool hasPluralSight = GetAndValidateBool("Does the developer have access to PluralSight? (y/n)");
            _devRepo.AddDeveloper(name, hasPluralSight);
        }

        private void ViewDevelopers()
        {

        }

        private void ViewDeveloperByName()
        {

        }

        private void UpdateDeveloper()
        {

        }

        private void DeleteDeveloper()
        {

        }

        private void CreateTeam()
        {

        }

        private void ViewTeams()
        {

        }

        private void ViewTeamByName()
        {

        }

        private void UpdateTeam()
        {

        }

        private void DeleteTeam()
        {

        }

        private string GetAndValidateInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        private bool GetAndValidateBool(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            if(input =="y")
            {
            return true;
            }
            return false;
        }

    }
}
