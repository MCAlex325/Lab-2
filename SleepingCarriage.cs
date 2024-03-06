namespace Lab_2
{
    internal class SleepingCarriage : Carriage
    {
        public int compartmentsCount {  get; set; }
        public bool HasShowers {  get; set; }

        public SleepingCarriage(string trainId, string Type, double trainLength, int compartmentsCount, bool hasShowers) : base(trainId, Type, trainLength)
        {
            compartmentsCount = 90;
            HasShowers = Random.Equals(true, false);
        }
    }
}
