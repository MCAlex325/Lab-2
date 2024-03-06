namespace Lab_2
{
    internal class PassengerCarriage : Carriage
    {
        public int seatsCount {  get; set; }
        public int countOfPassengers {  get; set; }
        public string comfortLevel {  get; set; }
        public PassengerCarriage(string trainId, int seatsCount, double trainLength) : base(trainId, "Passengers", trainLength)
        {
            seatsCount = 100;
        }
        public void loadPassengers()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть кількість пасажирів: ");
            countOfPassengers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Типи комфорту вагона: 1 - Economy, 2 - Business, 3 - Rich");
            Console.Write("Введіть опис комфорту вагона: ");

            comfortLevel = Console.ReadLine();

            Console.WriteLine($"Тип комфортних місць у вагоні {comfortLevel}");

            if (countOfPassengers > seatsCount)
            {
                Console.WriteLine("Кількість пасажирів більша за кількість місць у вагонах");
                countOfPassengers = seatsCount;
            }
        }
    }
}
