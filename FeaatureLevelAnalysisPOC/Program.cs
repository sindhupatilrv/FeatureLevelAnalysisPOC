using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json;

namespace FeatureLevelAnalysisPOC
{
    //class Program
    //{
    //    static async System.Threading.Tasks.Task Main(string[] args)
    //    {
    //        // Specify the raw content URL of the .feature file from GitHub
    //        string githubRawUrl = "https://github.com/sindhupatilrv/JustEatUKBMOTask/blob/bmointerviewtask/BMO_Task_To_Limit_From_Sindhu_Patil/src/main/java/Feature/JustEat_UK_TestScenario.feature";

    //        // Extract scenario names from the GitHub file
    //        var scenarioNames = await ExtractScenarioNamesFromGitHub(githubRawUrl);

    //        // Display scenario names
    //        Console.WriteLine("Scenarios Found:");
    //        foreach (var name in scenarioNames)
    //        {
    //            Console.WriteLine(name);
    //        }

    //        // Save scenario names to a JSON file
    //        string jsonFilePath = @"C:\Users\sindhupatil\Documents\\ScenarioLog.json";
    //        SaveToJson(scenarioNames, jsonFilePath);
    //    }

    //    static async System.Threading.Tasks.Task<List<string>> ExtractScenarioNamesFromGitHub(string url)
    //    {
    //        var scenarioNames = new List<string>();

    //        try
    //        {
    //            using (HttpClient client = new HttpClient())
    //            {
    //                // Fetch file content from GitHub
    //                var response = await client.GetAsync(url);
    //                response.EnsureSuccessStatusCode();
    //                var fileContent = await response.Content.ReadAsStringAsync();

    //                // Use regex to identify lines starting with "Scenario:"
    //                var scenarioRegex = new Regex(@"^\s*Scenario:\s*(.+)");

    //                foreach (var line in fileContent.Split('\n'))
    //                {
    //                    var match = scenarioRegex.Match(line);
    //                    if (match.Success)
    //                    {
    //                        scenarioNames.Add(match.Groups[1].Value.Trim());
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error fetching file from GitHub: {ex.Message}");
    //        }

    //        return scenarioNames;
    //    }

    //    static void SaveToJson(List<string> scenarioNames, string jsonFilePath)
    //    {
    //        // Convert the list to JSON format
    //        var json = JsonConvert.SerializeObject(scenarioNames, Newtonsoft.Json.Formatting.Indented);

    //        // Write JSON to the file
    //        System.IO.File.WriteAllText(jsonFilePath, json);

    //        Console.WriteLine($"Scenarios saved to JSON: {jsonFilePath}");
    //    }
    //}
}
