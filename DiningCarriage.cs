namespace Lab_2
{
    class DiningCarriage : Carriage
    {
        public int TablesCount { get; set; }
        public bool HasKitchen { get; set; }
        public int DiningSeats { get; private set; }


        public DiningCarriage(string id, string type, int tablesCount, bool hasKitchen)
            : base(id, "Dining_Carriage")
        {
            TablesCount = tablesCount = 40;
            HasKitchen = hasKitchen = true;
            DiningSeats = 40;
        }

        public double LoadFood(int passengers)
        {
            double foodPerPassenger = 0.5;
            return passengers * foodPerPassenger;
        }
    }
}