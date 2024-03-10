namespace Lab_2
{
    public abstract class Carriage
    {
        public string CarriageId { get; set; }
        public string CarriageType { get; set; }
        public double CarriageWeight { get; set; }
        public double TrainLength { get; set; }

        protected Carriage(string id, string type)
        {
            CarriageId = id;
            CarriageType = type;
            CarriageWeight = 26;
            TrainLength = 15.72;
        }
    }
}