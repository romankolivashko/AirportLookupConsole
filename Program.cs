using System;
using System.Threading.Tasks;
using RestSharp;

namespace AirportLookup
{
  class Program
  {
    static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
    }
  }

  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://6bda-98-237-209-225.ngrok.io/api/airports");
      RestRequest request = new RestRequest($"?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}