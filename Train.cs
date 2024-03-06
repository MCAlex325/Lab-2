namespace Lab_2
{
    public class Train : ITrain
    {
        public string Name { get; set; }
        public string routeNumber { get; set; }
        public List<Carriage> Carriages { get; set; }
    }
}
