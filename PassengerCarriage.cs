namespace Lab_2
{
    internal class PassengerCarriage : Carriage
    {
        public int seatsCount {  get; set; }
        public int countOfPassengers {  get; set; }
        public string comfortLevel {  get; set; }
        public PassengerCarriage(string ID, int Seatscount, int countOfPassengers) : base(ID, "Passenger")
        {
            seatsCount = Seatscount;
        }
        public void loadPassengers()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть кількість пасажирів: ");
            countOfPassengers = Convert.ToInt32(Console.ReadLine()); 
            if (countOfPassengers > seatsCount)
            {
                Console.WriteLine("Кількість пасажирів більша за кількість місць у вагонах");
                countOfPassengers = seatsCount;
            }
        }
    }
}
