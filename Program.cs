namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Train train = new Train("Id");
            train.InitializeTrain();

            train.PrintTrainInfo();

        }
    }
}