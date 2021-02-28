using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace BreweryDB_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var connection = "http://api.brewerydb.com/v2/beers/?key=40458894fcdedcacd895893ec611396a";

            var beerResponse = client.GetStringAsync(connection).Result;

            var beer = JsonConvert.DeserializeObject<BreweryList>(beerResponse);

            foreach (var b in beer.data)
            {
                Console.WriteLine($"Name: {b.name}\n" +
                    $"ABV: {b.abv}\n" +
                    $"ID: {b.id}\n" +
                    $"Description: {b.description}");
                Console.WriteLine("......................................");
            }
            
        
        }

    }
}
