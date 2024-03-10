namespace Lab_2
{
    public interface ITrain
    {
        string GetCarriageName { get; set; }
        List<Carriage> Carriage { get; set; }

        void AddCarriage(Carriage carriage);
        void PrintTrainInfo();

    }
}