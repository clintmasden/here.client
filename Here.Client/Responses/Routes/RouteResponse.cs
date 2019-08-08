using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Routes
{
    public class RouteResponse
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public MetaInfo MetaInfo { get; set; }

        [JsonProperty("Route")]
        public List<RouteResult> ResultList { get; set; }

        public string Language { get; set; }
    }
}