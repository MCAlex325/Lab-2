namespace Lab_2
{
    internal interface ITrain
    {
        string Name { get; set; }
        double MaxWeight { get; set; }
        List<Carriage> Carriage { get; set; }
    }
}
