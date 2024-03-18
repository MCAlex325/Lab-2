namespace Lab_2
{
    class SleepingCarriage : Carriage
    {
        public int CompartmentsCount { get; set; }
        public bool HasShowers { get; set; }
        public int MaxPassengers { get; private set; }
        public int CurrentPassengers { get; set; }


        public SleepingCarriage(string id, string type, double currentPassengers, int compartmentsCount, bool hasShowers)
            : base(id, "Sleeping_Carriage")
        {
            CompartmentsCount = compartmentsCount;
            HasShowers = hasShowers;
            CurrentPassengers = 0;
        }
    }
}