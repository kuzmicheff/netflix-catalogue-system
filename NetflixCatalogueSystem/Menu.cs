using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Menu
    {
        public void launchMenu()
        {
            Console.WriteLine("Netflix catalogue menu\n");
            Console.WriteLine("Press a to add a new item");
            Console.WriteLine("Press r to remove an item");
            Console.WriteLine("Press d to display all item");
            Console.WriteLine("Press q to quit the application\n");

            string input = null;
            Viewer viewer = new Viewer(); 

            while (input != "q")
            {
                Console.WriteLine("Select an option and press Enter:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine("Adding a title to catalogue");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        return;
                    case "r":
                        Console.WriteLine("Removing a title from catalogue");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        return;
                    case "d":
                        Console.WriteLine("Displaying the entire catalogue");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        viewer.importCatalogue();
                        viewer.displayCatalogue();
                        return;
                    case "q":
                        Console.WriteLine("Quitting the application");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        public void reloadMenu()
        {
            Console.WriteLine("Please press any key to return to menu:");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
