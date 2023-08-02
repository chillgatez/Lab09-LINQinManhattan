﻿using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Linq;

namespace Lab09_LINQinManhattan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string json = File.ReadAllText("C:\\Users\\raygr\\Documents\\Dev\\labs\\Lab9Demo\\data.json");
            Console.WriteLine("Read file into string");

            FeatureCollection featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json);
            Console.WriteLine("Deserialized the json data");

            Location[] locations = featureCollection.features;
            Console.WriteLine(locations);
            Part1WithLINQ(locations);




        }
        //Conner was here :D
        public static void Part1(Location[] items)
        {
            Dictionary<string, int> locationAppearances = new Dictionary<string, int>();
            for (int i = 0; i < items.Length; i++)
            {
                Location currentLocation = items[i];
                string neighborhood = currentLocation.properties.neighborhood;
                bool neighborhoodAlreadyInDictionary = locationAppearances.ContainsKey(neighborhood);
                if (neighborhoodAlreadyInDictionary == false)
                {
                    locationAppearances.Add(neighborhood, 1);
                }
                else
                {
                    int currentValue = locationAppearances.GetValueOrDefault(neighborhood);
                    int newValue = currentValue + 1;
                    locationAppearances[neighborhood] = newValue;

                }
            }

            foreach (var location in locationAppearances)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }

        }

        public static void Part1WithLINQ(Location[] items)
        {
            var neighborHoodQuery = from item in items
                                    group item by item.properties.neighborhood into grouped
                                    select new { Key = grouped.Key, Value = grouped.Count() };

            foreach (var location in neighborHoodQuery)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }

    }
}