using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Here.Client.Tests
{
    [TestClass]
    public class HereTests
    {
        private static HereClient _hereClient;

        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            _hereClient = new HereClient("APPID", "APPCODE");
        }

        [TestMethod]
        public void Geocode_GetByAddress_Json_Pass()
        {
            var result = _hereClient.GetGeocodeByAddressJson("ADDRESS").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Geocode_GetByAddress_Pass()
        {
            var result = _hereClient.GetGeocodeByAddress("ADDRESS").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByGeocode_Json_Pass()
        {
            var result = _hereClient.GetRouteByGeocodeJson("1,1", "1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByGeocode_Pass()
        {
            var result = _hereClient.GetRouteByGeocode(
                "1,1",
                "1,1",
                new Models.Routes.RouteType
                {
                    VehicleType = Models.Routes.VehicleTypes.Car,
                    ModeType = Models.Routes.ModeTypes.Fastest,
                    HasTraffic = true
                }).Result;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByAddress_Pass()
        {
            var result = _hereClient.GetRouteByAddress(
                "ADDRESS",
                "ADDRESS",
                    new Models.Routes.RouteType
                    {
                        VehicleType = Models.Routes.VehicleTypes.Car,
                        ModeType = Models.Routes.ModeTypes.Fastest,
                        HasTraffic = true
                    }).Result;

            Assert.IsTrue(result != null);

            result = _hereClient.GetRouteByAddress(
                "ADDRESS",
                "ADDRESS",
                    new Models.Routes.RouteType
                    {
                        VehicleType = Models.Routes.VehicleTypes.Car,
                        ModeType = Models.Routes.ModeTypes.Fastest,
                        HasTraffic = false
                    }).Result;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByBoundingBox_Json_Pass()
        {
            var result = _hereClient.GetIncidentsByBoundingBoxJson("1,1;1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByBoundingBox_Pass()
        {
            var result = _hereClient.GetIncidentsByBoundingBox("1,1;1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByAddress_Pass()
        {
            var result = _hereClient.GetIncidentsByAddress(
                "ADDRESS",
                "ADDRESS").Result;
            Assert.IsTrue(result != null);
        }
    }
}