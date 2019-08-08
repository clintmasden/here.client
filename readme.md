
# here.client
A .NET Standard/C# implementation of Here.com API.

| Name | Resources |
| ------ | ------ |
| APIs | https://developer.here.com |
| References | https://github.com/chadly/Geocoding.net |

|  Endpoints | |
| ------ | ------ |
| Geocoding |   Y |
| Geocoding Autocomplete |   N |
| Routing |   Y |
| Traffic |   Y |

#### Getting Started:
```
using System;
using Here.Client;
using Here.Client.Models;

namespace Here.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new HereClient("APPID", "APPCODE");

            var geocodeResult = client.GetGeocodeByAddress("address").Result;

            Console.WriteLine($"{geoCodeResult[0].Location.Address}");
            Console.Read();
        }
    }
}
```
