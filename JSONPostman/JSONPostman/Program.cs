using System.Text.Json;
using JSONPostman.Models;

namespace JSONPostman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dataPath = $"{FileRoot.Root}{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}";
            string[] bookNames = {"Babbitt", "Gameofthrones", "Midnightinchernobyl", "Mynameisasherlev", "Schindlerslist"};
            foreach (string book in bookNames)
            {
                string path = $"{dataPath}{book}.json";
                string jsonString = String.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    jsonString = sr.ReadToEnd();
                }
                var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                var b = JsonSerializer.Deserialize<Volume>(jsonString, options);
                Console.WriteLine(b);
                Console.WriteLine("======================================================================");
            }
        }
    }

}