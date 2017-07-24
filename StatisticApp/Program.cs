using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;

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
            fileName = Path.Combine(directory.FullName, "players.json");
            var players = DeserializePlayers(fileName);
            var topTenPlayers = GetTopTenPlayers(players);
            foreach (var player in players)
            {
                List<NewsSearch> newsSearch = GetNewsForPlayer(string.Format("{0} {1}", player.FirstName, player.SecondName));
                foreach (var search in newsSearch)
                {
                    Console.WriteLine(string.Format("Date: {0}, Headline: {1}, Summary: {2}", search.NewsValue,
                        search.ReadLink, search.TotalEstimatedMatches));
                }
            }
            fileName = Path.Combine(directory.FullName, "topten.json");
            SerializePlayersToFile(topTenPlayers, fileName);


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

        public static List<Player> GetTopTenPlayers(List<Player> players)
        {
            var topTenPlayers = new List<Player>();
            players.Sort(new PlayerComparer());
            int counter = 0;
            foreach (var player in players)
            {
                topTenPlayers.Add(player);
                counter++;
                if (counter == 10)
                    break;
            }
            return topTenPlayers;
        }

        public static void SerializePlayersToFile(List<Player> players, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, players);
            }

        }

        public static string GetGoogleHomePage()
        {
            var webClient = new WebClient();
            byte[] googleHome = webClient.DownloadData("https://www.google.com");

            using (var stream = new MemoryStream(googleHome))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<NewsSearch> GetNewsForPlayer(string playerName)
        {
            var search = new List<NewsSearch>();
            var webClient = new WebClient();
            webClient.Headers.Add("Ocp-Apim-Subscription-Key", "90b093df119545609387ef5131b462e9");
            byte[] searchResults = webClient.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={0}&mkt=en-us", playerName));
            var serializer = new JsonSerializer();
            using (var stream = new MemoryStream(searchResults))
            using (var reader = new StreamReader(stream))
            using(var jsonReader = new JsonTextReader(reader))
            {
                search = serializer.Deserialize<NewsSearch>(jsonReader).NewsValues;
            }
        }


    }
}

