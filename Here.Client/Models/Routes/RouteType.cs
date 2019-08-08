namespace Here.Client.Models.Routes
{
    // https://developer.here.com/documentation/routing/topics/routing-mode-parameter-combinations.html
    public class RouteType
    {
        public RouteType()
        {
            VehicleType = VehicleTypes.Car;
            ModeType = ModeTypes.Fastest;
            IsMetric = false;
            HasTraffic = true;
        }

        public VehicleTypes VehicleType { get; set; }

        internal string VehicleTypeString
        {
            get
            {
                switch (VehicleType)
                {
                    case VehicleTypes.Car:
                        return "car";

                    case VehicleTypes.CarHOV:
                        return "carHOV";

                    case VehicleTypes.Pedestrian:
                        return "pedestrian";

                    case VehicleTypes.Truck:
                        return "truck";

                    case VehicleTypes.Bicycle:
                        return "bicycle";
                }

                return null;
            }
        }

        public ModeTypes ModeType { get; set; }

        internal string ModeTypeString
        {
            get
            {
                return $"{ModeType.ToString().ToLower()}";
            }
        }

        public bool IsMetric { get; set; }

        internal string IsMetricString
        {
            get
            {
                if (IsMetric)
                {
                    return "metric";
                }

                return "imperial";
            }
        }

        public bool HasTraffic { get; set; }

        internal string HasTrafficString
        {
            get
            {
                if (HasTraffic)
                {
                    return $"enabled";
                }

                return $"disabled";
            }
        }
    }
}