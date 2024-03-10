namespace Lab_2
{
    public class PassengerCarriage : Carriage
    {
        public int SeatsCount { get; set; }
        public int Passengers { get; set; }
        public string ComfortLevel { get; set; }

        public PassengerCarriage(string id, int seatsCount, string comfortLevel)
            : base(id, "Passenger_Carriage")
        {
            SeatsCount = 100;
            ComfortLevel = comfortLevel;
        }

        public void LoadPassengers()
        {
            string comfortlevel;
            int passengers;
            do
            {
                Console.Write("Введіть клас вагону: (Наприклад - 'Business'): \n\n");
                comfortlevel = Console.ReadLine();
                Console.Clear();
                Console.Write("Введіть кількість пасажирів: \n\n");
                passengers = Convert.ToInt32(Console.ReadLine());
                if (passengers > SeatsCount)
                {
                    Console.WriteLine($"\nКількість пасажирів не може перевищувати кількість місць. \n\nМаксимальна кількість місць {SeatsCount}");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (passengers > SeatsCount);
            Passengers = passengers;
            ComfortLevel = comfortlevel;
        }
    }
}