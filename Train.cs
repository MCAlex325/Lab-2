namespace Lab_2
{
    public class Train : ITrain
    {
        public string Id { get; set; }
        public string GetCarriageName { get; set; }
        public double LoadCapacity { get; set; }
        public MaterialType Material { get; set; }
        public double Weight { get; set; }
        public List<Carriage> Carriage { get; set; }
        public double TotalLoad { get; set; }
        public List<FreightCarriage> FreightCarriages { get; set; }
        public void AddCarriage(Carriage carriage)
        {
            Carriage.Add(carriage);
        }

        public Train(string id)
        {
            Id = id;
            Carriage = new List<Carriage>();
            FreightCarriages = new List<FreightCarriage>();
        }

        private bool hasFreightCarriages = false;

        public void AddCarriage(int type, int passengers = 0, string comfortLevel = null, int foodLoad = 0, int tablesCount = 0, 
            bool hasKitchen = false, int compartmentsCount = 0, bool hasShowers = false, double loadCapacity = 0)
        {
            string id;
            switch (type)
            {
                case 1:
                    id = (Carriage.Count + 1).ToString();
                    PassengerCarriage passengerCarriage = new PassengerCarriage(id, 30, comfortLevel);
                    passengerCarriage.LoadPassengers();
                    Carriage.Add(passengerCarriage);
                    break;

                case 2:
                    Console.Write("Виберіть тип матеріалу:");
                    foreach (var material in Enum.GetValues(typeof(MaterialType)))
                    {
                        Console.WriteLine($"{(int)material}. {(string)material}");
                    }
                    MaterialType chosenMaterial = (MaterialType)Enum.Parse(typeof(MaterialType), Console.ReadLine());

                    string materialName = chosenMaterial.ToString();

                    Console.Write("Введіть вагу вантажу: ");
                    double cargoWeight = Convert.ToDouble(Console.ReadLine());

                    double maxLoad = LoadCapacity;
                    

                    if (cargoWeight > maxLoad)
                    {
                        Console.WriteLine($"Вантаж не може перевищувати максимальну вантажопідйомність вагона для {materialName}.");
                    }
                    else
                    {
                        id = (Carriage.Count + 1).ToString();
                        FreightCarriage freightCarriage = new FreightCarriage(id, maxLoad, chosenMaterial);

                        freightCarriage.Load = cargoWeight;
                        Carriage.Add(freightCarriage);
                        Console.WriteLine($"Вантаж {materialName} завантажено.");
                    }
                    break;

                case 3:
                    if (loadCapacity > 500)
                    {
                        Console.WriteLine("Завантаження їжі не може перевищувати 500 кг.");
                        return;
                    }
                    id = (Carriage.Count + 1).ToString();
                    DiningCarriage diningCarriage = new DiningCarriage(id, "Dining", tablesCount, hasKitchen);
                    Console.Write("Введіть кількість пасажирів для завантаження їжі: ");
                    int foodPassengers = int.Parse(Console.ReadLine());
                    diningCarriage.LoadFood(foodPassengers);
                    Carriage.Add(diningCarriage);
                    break;

                case 4:
                    id = (Carriage.Count + 1).ToString();
                    SleepingCarriage sleepingCarriage = new SleepingCarriage(id, "Sleeping", loadCapacity, compartmentsCount, hasShowers);
                    Console.Write("Введіть кількість пасажирів для завантаження: ");
                    int sleepPassengers = int.Parse(Console.ReadLine());
                    sleepingCarriage.AddPassengers(sleepPassengers);
                    Carriage.Add(sleepingCarriage);
                    break;

                default:
                    Console.WriteLine("Невідомий тип вагону.");
                    break;
            }

        }
        private List<Carriage> carriages = new List<Carriage>();

        public void RemoveCarriage()
        {
            string userInput = "";
            while (true)
            {
                Console.Clear();
                Console.Write("Ви хочете видалити вагон? (1 - так, 2 - ні): ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowCarriages();

                        Console.Write("Введіть номер вагону, який ви хочете видалити: ");
                        string carriageInput = Console.ReadLine();
                        int carriageNumber;
                        if (Int32.TryParse(carriageInput, out carriageNumber) && carriageNumber > 0 && carriageNumber <= Carriage.Count)
                        {
                            Carriage.RemoveAt(carriageNumber - 1);
                            for (int i = carriageNumber - 1; i < Carriage.Count; i++)
                            {
                                Carriage[i].CarriageId = (i + 1).ToString();
                            }
                            Console.WriteLine("Вагон успішно видалено.");
                        }
                        else
                        {
                            Console.WriteLine("Вагону з таким номером не існує.");
                        }
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Невідома команда. Будь ласка, введіть 1, щоб видалити вагон, або 2, щоб завершити.");
                        break;
                }
            }
        }

        public void ShowCarriages()
        {
            Console.WriteLine("Список всіх вагонів:");
            foreach (Carriage carriage in Carriage)
            {
                Console.Clear();
                Console.WriteLine($"ID: {carriage.CarriageId}\nТип: {carriage.CarriageType}");
            }
        }

        public void InitializeTrain()
        {
            Console.Write("Введіть назву потягу: ");
            GetCarriageName = Console.ReadLine();

            bool continueAdding = true;
            while (continueAdding)
            {
                Console.Write("Виберіть тип вагонів (1 - пасажирський, 2 - вантажний, 3 - вагон-ресторан, 4 - спальний вагон): ");
                int type = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть кількість вагонів цього типу: ");
                int carriageCount = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < carriageCount; i++)
                {
                    AddCarriage(type);
                }

                Console.WriteLine("Бажаєте додати інший тип вагону? (1 - так, 2 - ні)");
                string userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        continueAdding = true;
                        break;
                    case "2":
                        continueAdding = false;
                        break;
                    default:
                        Console.WriteLine("Невідома відповідь. Будь ласка, введіть 1 для 'так' або 2 для 'ні'.");
                        break;
                }
            }
            RemoveCarriage();
        }
        public void PrintTrainInfo()
        {
            Console.WriteLine($"Train Name: {GetCarriageName}");
            
            Console.WriteLine($"Кількість вагонів: {Carriage.Count}");
            Console.WriteLine("Інформація про вагони:");
            double totalLoad = 0;
            double totalWeight = 0;
            double totalLength = 0;
            int totalPassengers = 0;
            string finalComfortLevel = null;
            foreach (var carriage in Carriage)
            {
                string cargoType = "";
                switch (carriage)
                {
                    case PassengerCarriage passengerCarriage:
                        cargoType = "Люди";
                        totalPassengers += passengerCarriage.Passengers;
                        finalComfortLevel = passengerCarriage.ComfortLevel;
                        break;
                    case FreightCarriage freightCarriage:
                        cargoType = freightCarriage.Material.ToString();

                        totalLoad += freightCarriage.Load;

                        break;
                    case DiningCarriage diningCarriage:
                        cargoType = "Їжа";
                        totalLoad += diningCarriage.LoadFood(diningCarriage.DiningSeats);
                        Console.WriteLine($"Кількість столів: {diningCarriage.TablesCount}");
                        Console.WriteLine($"Наявність кухні: {diningCarriage.HasKitchen}");
                        break;
                    case SleepingCarriage sleepingCarriage:
                        cargoType = "Люди";
                        totalPassengers += sleepingCarriage.CurrentPassengers;
                        Console.WriteLine($"Наявність душу: {sleepingCarriage.HasShowers}");
                        Console.WriteLine($"Кількість пасажирів: {sleepingCarriage.MaxPassengers}");
                        break;
                    default:
                        Console.WriteLine("Невідомий тип вагону.");
                        break;
                }
                Console.WriteLine($"ID вагону: {carriage.CarriageId}, Тип: {carriage.CarriageType}, Вага: {carriage.CarriageWeight}, Довжина: {carriage.TrainLength}, Тип матеріалу: {cargoType}");
                totalWeight += carriage.CarriageWeight;
                totalLength += carriage.TrainLength;
            }
            Console.WriteLine($"Загальна довжина потягу: {totalLength} метрів");
            Console.WriteLine($"Клас пасажирських вагонів: {finalComfortLevel}");
            Console.WriteLine($"Загальна кількість пасажирів: {totalPassengers}");
            Console.WriteLine($"Загальна вага потягу: {totalWeight} тон");
        }
    }
}