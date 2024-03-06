namespace Lab_2
{
    internal class Engine
    {
        public string ID { get; set; } = "EngineNo1";
        public double MaxSpeed { get; set; }
        public double MaxLoad { get; set; }
        public double trainLength { get; set; }

        public Engine(double maxSpeed, double maxLoad, double trainLength) 
        { 
            MaxSpeed = maxSpeed;
            MaxLoad = 800;
            trainLength = 25;
        }
    }
}
