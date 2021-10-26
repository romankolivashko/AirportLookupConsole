using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AirportLookup
{
  class Program
  {
    static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("[YOUR-API-KEY-HERE]");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
      //JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      //Console.WriteLine(jsonResponse["results"]);
      //List<Airport> airportList = JsonConvert.DeserializeObject<List<Airport>>(jsonResponse["results"].ToString());
    
    //  foreach (Airport airport in airportList)
    //   {
    //     Console.WriteLine($"AirportId: {airport.AirportId}");
    //     Console.WriteLine($"Name: {airport.Name}");
    //     Console.WriteLine($"Code: {airport.Code}");
    //     Console.WriteLine($"City: {airport.City}");
    //     Console.WriteLine($"BiggestAirline: {airport.BiggestAirline}");
    //   }
    }
  }

  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("http://7ff0-98-237-209-225.ngrok.io/api/airports");
      RestRequest request = new RestRequest($"?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}