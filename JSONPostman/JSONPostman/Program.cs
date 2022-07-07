using System.Text.Json;
using JSONPostman.Models;

namespace JSONPostman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dataPath = $"{FileRoot.Root}{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}";
            string[] bookNames = { "Babbitt", "Gameofthrones", "Midnightinchernobyl", "Mynameisasherlev", "Schindlerslist" };
            foreach (string book in bookNames)
            {
                string path = $"{dataPath}{book}.json";
                string jsonString = String.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    jsonString = sr.ReadToEnd();
                }
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var b = JsonSerializer.Deserialize<Book>(jsonString, options);
                Console.WriteLine(b);
                Console.WriteLine("======================================================================");
            }

            string[] authors = { "Wise Brown", "Margaret Wise Brown" };
            VolumeInfo vi = new VolumeInfo("Goodnight Moon", "In a great green room, tucked away in bed, is a little bunny. \"Goodnight room, goodnight moon.\" And to all the familiar things in the softly lit room—to the picture of the three little bears sitting in chairs, to the clocks and his socks, to the mittens and the kittens, to everything one by one—he says goodnight.", authors);
            Item i = new Item("L5bxPI2YhfEC", "https://www.googleapis.com/books/v1/volumes/L5bxPI2YhfEC", vi);

            List<Item> details = new List<Item>();
            details.Add(i);
            Book foo = new Book(details);

            string jsonOutString = JsonSerializer.Serialize(foo);
            string outFile = $"{FileRoot.Root}{Path.DirectorySeparatorChar}{vi.Title}.json";

            using (StreamWriter writer = new StreamWriter(outFile))
            {
                writer.WriteLine(jsonOutString);
            }
        }
    }

}