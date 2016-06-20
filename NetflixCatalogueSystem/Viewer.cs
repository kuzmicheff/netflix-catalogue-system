using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NetflixCatalogueSystem
{
    class Viewer
    {
        string dataImport;
        string dataExport;
        List<Catalogue> items;

        public void importCatalogue()
        {
            //read file into a string and deserialize JSON to a type
            try
            {
                dataImport = File.ReadAllText("files/netflix.json");
                items = JsonConvert.DeserializeObject<List<Catalogue>>(dataImport);

                if (items == null)
                {
                    items = new List<Catalogue>();
                }
            }
            catch (Exception readError)
            {
                DateTime timeStamp = DateTime.Now;
                timeStamp.ToString();
                StreamWriter errorFile = File.AppendText("files/errors.txt");
                errorFile.WriteLine("{0}: {1}", timeStamp, readError.Message);
                Console.WriteLine(readError.Message);
                errorFile.Close();
            }
        }

        public void displayCatalogue()
        {
            Console.WriteLine("Neflix Catalogue: all titles\n");
            foreach (Catalogue item in items)
            {
                Console.WriteLine("Type: " + item.type);
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("Duration: " + item.duration);
                Console.WriteLine("Rating: " + item.rating);
                string genres = null;
                if (item.genre.Count > 1)
                {
                    int i;
                    for (i = 0; i < item.genre.Count - 1; i++)
                    {
                        genres += item.genre[i] + ", ";

                    }
                    genres += item.genre[item.genre.Count - 1];
                }
                else
                {
                    genres = item.genre[0];
                }
                Console.WriteLine("Genre: " + genres);
                Console.WriteLine();
                //this check makes the type key in JSON file technically unnecessary
                if (item.episode != null)
                {
                    Console.WriteLine("Episodes\n");
                    foreach (Episode episode in item.episode)
                    {
                        Console.WriteLine(episode.number + ". " + episode.name);
                        Console.WriteLine("Duration: " + episode.duration);
                        Console.WriteLine("Rating: " + episode.rating);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }

        public void displayGenres()
        {

        }

        public void exportCatalogue()
        {
            Console.WriteLine("Updating app data\n");
            dataExport = JsonConvert.SerializeObject(items);
            File.WriteAllText("files/netflix.json", dataExport);
        }
    }
}
