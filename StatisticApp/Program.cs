using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StatisticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Pricing_data.csv");
            var fileContents = ReadPricingData(fileName);
            fileName = Path.Combine(directory.FullName, "player.json");
            var players = DeserializePlayers(fileName);

            foreach (var player in players)
            {
                Console.WriteLine(player.second_name);
            }
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<PriceResults> ReadPricingData(string fileName)
        {
            var pricingData = new List<PriceResults>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    var priceResults = new PriceResults();
                    string[] values = line.Split(',');

                    DateTime priceDate;
                    if (DateTime.TryParse(values[0], out priceDate))
                    {
                        priceResults.PriceDate = priceDate;
                    }

                    priceResults.AssetName = values[1];
                    Branch branch;
                    if (Enum.TryParse(values[4], out branch))
                    {
                        priceResults.Branch = branch;
                    }

                    double parseDouble;
                    if (double.TryParse(values[6], out parseDouble))
                    {
                        priceResults.InitialPrice = parseDouble;
                    }
                    if (double.TryParse(values[7], out parseDouble))
                    {
                        priceResults.FinalPrice = parseDouble;
                    }
                    if (double.TryParse(values[11], out parseDouble))
                    {
                        priceResults.PriceAfterSold = parseDouble;
                    }
                    if (double.TryParse(values[12], out parseDouble))
                    {
                        priceResults.PriceBeforeSold = parseDouble;
                    }
                    pricingData.Add(priceResults);
                }
            }
            return pricingData;
        }

        public static List<Player> DeserializePlayers(string fileName)
        {
            var players = new List<Player>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using(var jsonReader = new JsonTextReader(reader))
            {
               players = serializer.Deserialize<List<Player>>(jsonReader);
            }
            return players;
        }
    }
}
