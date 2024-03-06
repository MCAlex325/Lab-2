namespace Lab_2
{
    internal interface ITrain
    {
        string Name { get; set; }
        string routeNumber { get; set; }
        List<Carriage> Carriages { get; set; }
    }
}
