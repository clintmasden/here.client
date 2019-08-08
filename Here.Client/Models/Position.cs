namespace Here.Client.Models
{
    public class Position
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }
    }
}