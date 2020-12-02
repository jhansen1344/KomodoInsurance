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
            _devRepo.SeedContent();
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
                    "3. View Individual Developer\n" +
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
            bool result = _devRepo.AddDeveloper(name, hasPluralSight);
            if (result)
            {
                Console.WriteLine("Developer Successfully Added");
            }
            else
            {
                Console.WriteLine("Unable To Add Developer");
            }
        }

        private void ViewDevelopers()
        {
            Console.Clear();
            List<Developer> availableDevelopers = GetDevelopers();
            Console.WriteLine("Id \t Name");
            foreach (var developer in availableDevelopers)
            {
                Console.WriteLine($"{developer.Id}. \t {developer.Name}");
            }

            
        }

        private void ViewDeveloperByName()
        {
            Developer devToView = GetDeveloper();
            if (devToView == null)
            {
                Console.WriteLine("Error retrieving developer");
            }
            else
            {
                Console.WriteLine("Id \t Name \t\t Has Access To Pluarl Sight");
                Console.WriteLine($"{devToView.Id} \t {devToView.Name} \t {devToView.HasPluralSight}");
            }


        }

        private Developer GetDeveloper()
        {
            Console.Clear();
            ViewDevelopers();
            int response = GetAndValidateInt("Enter the number of the developer you wish to see.");
            Console.Clear();
            Developer devToView = _devRepo.ReturnDeveloperById(response);
            return devToView;
        }

        private void UpdateDeveloper()
        {
            Developer devToUpdate = GetDeveloper();
            Console.WriteLine($"Current Name: {devToUpdate.Name}");
            string newName = GetAndValidateInput("Enter new name for developer");
            Console.WriteLine($"Developer currently has access to PluaralSight: {devToUpdate.HasPluralSight}");
            bool newAccess = GetAndValidateBool("Does the developer have access to PluralSight?");
            bool response = _devRepo.UpdateDeveloper(devToUpdate.Id, newName, newAccess);
            if(response)
            {
                Console.WriteLine("Developer successfully updated");
            }
            else
            {
                Console.WriteLine("Unable to update developer");
            }
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

        private List<Developer> GetDevelopers()
        {
            List<Developer> availableDevelopers = new List<Developer>();
            availableDevelopers = _devRepo.ReturnDevelopers();
            return availableDevelopers;
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
            if (input == "y")
            {
                return true;
            }

            return false;
        }

        private int GetAndValidateInt(string message)
        {
            int num;
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num));

            return num;
        }

    }
}
