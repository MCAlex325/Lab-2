namespace Lab_2
{
    internal class DiningCarriage : Carriage
    {
        public int TablesCount { get; set; }
        public bool HasKitchen { get; set; }

        public DiningCarriage(string trainId, string Type, double trainLength, int tablesCount, bool HasKitchen) : base(trainId, Type, trainLength)
        {
            TablesCount = tablesCount = 10;
            HasKitchen = Random.Equals(true, false);
        }
    }
}
