using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Linq;

namespace Lab09_LINQinManhattan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Read file into string
            string json = File.ReadAllText("C:\\Users\\Student-14\\source\\repos\\chillgatez\\Lab09-LINQinManhattan\\Lab09-LINQinManhattan\\data.json");

            //Deserialized the json data
            FeatureCollection featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json);

            Location[] locations = featureCollection.features;

            // Question 1
            Part1(locations);

            // Question 2
            Part2(locations);

            // Question 3
            Part3(locations);

            // Question 4
            Part4(locations);

            // Question 5
            Part5(locations);
        }

        // Question 5: Rewrite using opposing method (Method Syntax)
        public static void Part5(Location[] items)
        {
            Console.WriteLine("Question 5 - Using Method Syntax:");
            var neighborhoods = items.Where(item => !string.IsNullOrEmpty(item.properties.neighborhood))
                                     .GroupBy(item => item.properties.neighborhood)
                                     .Select(grouped => new { Key = grouped.Key, Value = grouped.Count() });

            foreach (var location in neighborhoods)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
            Console.WriteLine($"Final Total: {neighborhoods.Count()} neighborhoods");
            Console.WriteLine();
        }

        // Question 4: Consolidate into a single query
        public static void Part4(Location[] items)
        {
            Console.WriteLine("Question 4 - Single query:");
            var neighborhoods = items.Select(item => item.properties.neighborhood)
                                     .Where(neighborhood => !string.IsNullOrEmpty(neighborhood))
                                     .Distinct();
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoods.Count()} neighborhoods");
            Console.WriteLine();
        }

        // Question 3: Remove duplicates
        public static void Part3(Location[] items)
        {
            Console.WriteLine("Question 3 - Remove duplicates:");
            var neighborhoods = items.Where(item => !string.IsNullOrEmpty(item.properties.neighborhood))
                                     .Select(item => item.properties.neighborhood)
                                     .Distinct();
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoods.Count()} neighborhoods");
            Console.WriteLine();
        }

        // Question 2: Filter out neighborhoods with no names
        public static void Part2(Location[] items)
        {
            Console.WriteLine("Question 2 - Filter neighborhoods with names:");
            var neighborhoods = items.Where(item => !string.IsNullOrEmpty(item.properties.neighborhood))
                                     .Select(item => item.properties.neighborhood);
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoods.Count()} neighborhoods");
            Console.WriteLine();
        }

        // Question 1: Output all of the neighborhoods
        public static void Part1(Location[] items)
        {
            Console.WriteLine("Question 1 - Output all neighborhoods:");
            var neighborhoods = items.Select(item => item.properties.neighborhood);
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoods.Count()} neighborhoods");
            Console.WriteLine();
        }
    }
}