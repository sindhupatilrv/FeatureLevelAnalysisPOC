using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FeaatureLevelAnalysisPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            string featureFilePath = @"C:\Yourlocalpath\FeaatureLevelAnalysisPOC\FeatureLevelAnalysisPOC\Feature.feature";

           // Console.WriteLine("Enter the full path of the .feature file:");
            //string featureFilePath = Console.ReadLine();

            if (!File.Exists(featureFilePath))
            {
                Console.WriteLine("Feature file not found.");
                return;
            }

            var scenarioNames = ExtractScenarioNames(featureFilePath);


            Console.WriteLine("Scenario Names:");
            foreach (var scenarioName in scenarioNames)
            {
                Console.WriteLine($"- {scenarioName}");
            }

            string jsonFilePath = @"C:\Users\sindhupatil\Documents\ScenarioNames.json";
            SaveToJson(scenarioNames, jsonFilePath);
        }

        static List<string> ExtractScenarioNames(string filePath)
        {
            var scenarioNames = new List<string>();

            var lines = File.ReadAllLines(filePath);

            var scenarioRegex = new Regex(@"^\s*Scenario:\s*(.+)");

            foreach (var line in lines)
            {
                var match = scenarioRegex.Match(line);
                if (match.Success)
                {
                    scenarioNames.Add(match.Groups[1].Value.Trim()); // Extract scenario title
                }
            }

            return scenarioNames;
        }

        static void SaveToJson(List<string> scenarioNames, string jsonFilePath)
        {
            // Convert the list to JSON format
            var json = JsonConvert.SerializeObject(scenarioNames, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            Console.WriteLine($"Scenario names saved to JSON file: {jsonFilePath}");
        }
    }
}