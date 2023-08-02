# Lab09-LINQinManhattan
This C# console application demonstrates the use of LINQ queries and Lambda expressions to process and analyze location data for properties in Manhattan. The data is read from an external JSON file and then filtered and manipulated to answer specific questions about the neighborhoods in Manhattan.

## Summary
The application reads location data from a JSON file, processes it using LINQ queries and Lambda expressions, and then outputs the results to the console. It addresses the following questions:

1. Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods).
1. Filter out all the neighborhoods that do not have any names (Final Total: 143).
1. Remove the duplicates (Final Total: 39 neighborhoods).
1. Rewrite the queries from above and consolidate all into one single query.
1. Rewrite at least one of these questions using the opposing LINQ method (method syntax instead of query syntax or vice versa).

## Visuals
**part1**
![part1](https://github.com/chillgatez/Lab09-LINQinManhattan/blob/Kelsee-Lab09/Screenshot%20(30).png?raw=true)

**part2**
![part2](https://github.com/chillgatez/Lab09-LINQinManhattan/blob/Kelsee-Lab09/Screenshot%20(31).png?raw=true)

**part3/4**
![part3](https://github.com/chillgatez/Lab09-LINQinManhattan/blob/Kelsee-Lab09/Screenshot%20(32).png?raw=true)

**part5**
![part5](https://github.com/chillgatez/Lab09-LINQinManhattan/blob/Kelsee-Lab09/Screenshot%20(34).png?raw=true)

## How to Use
1. Clone the repository to your local machine.
1. Ensure you have the Newtonsoft.Json NuGet package installed in the project.
1. Locate the data.json file in the project root folder and verify that it contains the location data in the provided format.
1. Build and run the application.
1. The application will read the data from the data.json file and display the results of each question in the console.

## Step-by-Step Directions
1. Open the Program.cs file in the project to view the source code.
1. Locate the Main method, which serves as the entry point for the application.
1. Inside the Main method, the application reads the data from the JSON file using JsonConvert.Deserialize, deserializing it into a FeatureCollection object.
1. The location data is extracted from the FeatureCollection object and stored in an array of Location objects.
1. The method Part1WithLINQ uses LINQ query syntax to group the locations by neighborhood and count the occurrences of each neighborhood. It outputs the result to the console.
1. The method Part2 uses LINQ method syntax to filter out neighborhoods with empty names and outputs the filtered locations to the console.
1. The method Part3 demonstrates removing duplicates by using LINQ method syntax with the Distinct method. It outputs the distinct neighborhoods to the console.
1. The method Part4 consolidates the queries from the previous parts into a single query using LINQ method chaining.
1. The method Part5 rewrites one of the previous queries (Part1) using the opposing LINQ syntax (query syntax) for educational purposes.

## Other Details
- The Location class represents a single location with properties like zip code, city, state, address, borough, neighborhood, and county.
- The FeatureCollection class is used to deserialize the JSON data into C# objects.
- The application uses Newtonsoft.Json for JSON serialization and deserialization.
- This application serves as a useful example of how to utilize LINQ and Lambda expressions in C# to process data effectively. It can be extended or modified to handle more complex data analysis tasks or used as a reference for future projects that require similar data processing capabilities.
