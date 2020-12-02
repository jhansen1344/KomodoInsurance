using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceUI
{
    public class CaseyMenu
    {
        public void Run()
        {
            var whatToDo = 1;
            switch (whatToDo)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Press D to add a Developer or press T to add a Team.");
                    var userInput = Console.ReadKey().Key;
                    if (userInput == ConsoleKey.D)
                    {
                        Console.WriteLine("Create New Developer");
                        Console.ReadKey();
                        break;
                    }
                    else if (userInput == ConsoleKey.T)
                    {
                        Console.WriteLine("Create New Team");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Press any key to continue.");
                        Console.ReadKey();
                        goto case 1;
                    }
            }
        }
    }
}
