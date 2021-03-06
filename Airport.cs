using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace AirportLookup
{
  public class Airport
  {
    public int AirportId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string City { get; set; }
    public string BiggestAirline { get; set; }
  }
}