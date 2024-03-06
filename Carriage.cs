namespace Lab_2
{
    public abstract class Carriage
    {
        public string trainId { get; set; }
        private string Type { get; set; }
        private double trainLength { get; set; }
        public Carriage (string trainId, string Type, double trainLength)
        {
            this.trainId = trainId;
            this.Type = Type;
            trainLength = 25;
        }
    }
}
