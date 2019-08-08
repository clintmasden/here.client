using Here.Client.Responses.Geocodes;
using Here.Client.Responses.Incidents;
using Here.Client.Responses.Routes;
using RestEase;
using System.Threading.Tasks;

namespace Here.Client.Interfaces
{
    public interface IHereClient
    {
        [Path("appId")]
        string AppId { get; set; }

        [Path("appCode")]
        string AppCode { get; set; }

        [Get("6.2/geocode.json?searchtext={address}&app_id={appId}&app_code={appCode}")]
        Task<string> GetGecodeByAddressJsonAsync([Path] string address);

        [Get("6.2/geocode.json?searchtext={address}&app_id={appId}&app_code={appCode}")]
        Task<GeocodeResponse> GetGecodeByAddressAsync([Path] string address);

        [Get("7.2/calculateroute.json?waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}&app_id={appId}&app_code={appCode}")]
        Task<string> GetRouteByAddressJsonAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic);

        [Get("7.2/calculateroute.json?waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}&app_id={appId}&app_code={appCode}")]
        Task<RouteResponse> GetRouteByAddressAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic);

        [Get("6.0/incidents.json?bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact&app_id={appId}&app_code={appCode}")]
        Task<string> GetIncidentsByBoundingBoxJsonAsync([Path] string boundingBox);

        [Get("6.0/incidents.json?bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact&app_id={appId}&app_code={appCode}")]
        Task<IncidentResponse> GetIncidentsByBoundingBoxAsync([Path] string boundingBox);
    }
}