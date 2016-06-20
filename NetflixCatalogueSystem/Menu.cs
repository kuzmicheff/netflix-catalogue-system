using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NetflixCatalogueSystem
{
    class Menu
    {
        public void launchMenu()
        {
            Console.WriteLine("Netflix catalogue menu\n");
            Console.WriteLine("Press a to add a new title");
            Console.WriteLine("Press r to remove an title");
            Console.WriteLine("Press t to display all titles");
            Console.WriteLine("Press g to display all genres");
            Console.WriteLine("Press c to customize genres");
            Console.WriteLine("Press q to quit the application\n");

            string input = null;
            Viewer viewer = new Viewer();
            viewer.importCatalogue();

            while (input != "q")
            {
                Console.WriteLine("Select an option and press Enter:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine("Adding a title to catalogue");
                        Thread.Sleep(1000);
                        Console.Clear();
                        reloadMenu();
                        return;
                    case "r":
                        Console.WriteLine("Removing a title from catalogue");
                        Thread.Sleep(1000);
                        Console.Clear();
                        reloadMenu();
                        return;
                    case "t":
                        Console.WriteLine("Displaying all catalogue titles");
                        Thread.Sleep(1000);
                        Console.Clear();
                        viewer.displayCatalogue();
                        reloadMenu();
                        return;
                    case "g":
                        Console.WriteLine("Displaying titles grouped by genre");
                        Thread.Sleep(1000);
                        Console.Clear();
                        viewer.displayGenres();
                        reloadMenu();
                        return;
                    case "c":
                        Console.WriteLine("Loading genre customization menu");
                        Thread.Sleep(1000);
                        Console.Clear();
                        customizeGenresMenu();
                        reloadMenu();
                        return;
                    case "q":
                        Console.WriteLine("Quitting the application");
                        Thread.Sleep(1000);
                        viewer.exportCatalogue();
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
            Thread.Sleep(1000);
            Console.Clear();
            launchMenu();
        }

        public void customizeGenresMenu()
        {
            //press 1, 2, or 3 to select option or any other key to return to main menu
        }

    }
}
