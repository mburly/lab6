using Newtonsoft.Json;
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
                    // Rather than first putting the file contents into a string,
                    // we can just deserialize the JSON now
                    JsonSerializer seralizer = new JsonSerializer();
                    Book v = (Book)seralizer.Deserialize(sr, typeof(Book));
                    Console.WriteLine(v);
                    Console.WriteLine("======================================================================");
                }
            }

            string[] authors = { "Wise Brown", "Margaret Wise Brown" };
            VolumeInfo vi = new VolumeInfo("Goodnight Moon", "In a great green room, tucked away in bed, is a little bunny. \"Goodnight room, goodnight moon.\" And to all the familiar things in the softly lit room—to the picture of the three little bears sitting in chairs, to the clocks and his socks, to the mittens and the kittens, to everything one by one—he says goodnight.", authors);
            Item i = new Item("L5bxPI2YhfEC", "https://www.googleapis.com/books/v1/volumes/L5bxPI2YhfEC", vi);

            List<Item> details = new List<Item>();
            details.Add(i);
            Book foo = new Book(details);

            string outFile = $"{FileRoot.Root}{Path.DirectorySeparatorChar}{vi.Title}.json";

            using (StreamWriter writer = new StreamWriter(outFile))
            {
                // Same as above, but serializing
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, foo);
            }
        }
    }
}