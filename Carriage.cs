namespace Lab_2
{
    public abstract class Carriage
    {
        private string trainId { get; set; }
        private string trainType { get; set; }
        private double trainWeight { get; set; }
        private double trainLength { get; set; }
        protected Carriage (string ID, string Type)
        {
            trainId = ID;
            trainType = Type;
            trainWeight = 25;
            trainLength = 25;
        }
    }
}
