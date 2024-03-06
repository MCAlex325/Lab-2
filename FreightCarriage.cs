namespace Lab_2
{
    public enum MaterialType
    {
        Дерево = 1, Алюміній = 2, Залізо = 3, Вугілля = 4, ВажкіМетали = 5, Щебінь = 6, Газ = 7, ІншийМатеріал = 8,
    }
    public class FreightCarriage : Carriage
    {
        public double LoadCapacity {  get; set; }
        public MaterialType cargoType {  get; set; }
        public string OtherMaterial {  get; set; }

        public FreightCarriage(string trainId, string Type, double trainLength, double LoadCapacity, MaterialType CargoType) : base(trainId, Type, trainLength)
        {
            LoadCapacity = 0;
            cargoType = CargoType;
            OtherMaterial = "";
        }

        public void LoadCarriage()
        {
            foreach (var cargoType in Enum.GetValues(typeof(MaterialType)))
            {
                Console.WriteLine($"{(int)cargoType} - {(string)cargoType}");
            }
            MaterialType ChosenMaterial = (MaterialType)Enum.Parse(typeof(MaterialType), Console.ReadLine());
            Console.Write("Виберіть тип матеріалу: ");

            if (ChosenMaterial == MaterialType.ІншийМатеріал)
            {
                Console.Write("Введіть назву матеріалу: ");
                OtherMaterial = Console.ReadLine();
            }

            Console.Write("Введіть вагу вантажу: ");
            double Weight = Convert.ToDouble(Console.ReadLine());



            double MaxLoad = LoadCapacity;

            switch (ChosenMaterial)
            {
                case MaterialType.Дерево:
                    MaxLoad = 100;
                    break;
                case MaterialType.Алюміній:
                    MaxLoad = 400;
                    break;
                case MaterialType.Залізо:
                    MaxLoad = 75;
                    break;
                case MaterialType.Вугілля:
                    MaxLoad = 75;
                    break;
                case MaterialType.ВажкіМетали:
                    MaxLoad = 50;
                    break;
                case MaterialType.Щебінь:
                    MaxLoad = 200;
                    break;
                case MaterialType.Газ:
                    MaxLoad = 100;
                    break;
                case MaterialType.ІншийМатеріал:
                    MaxLoad = 100;
                    break;
            }
            if (Weight > MaxLoad)
            {
                Console.WriteLine($"{ChosenMaterial} не може перевищувати вантажопідйомність вагона");
            }
            else
            {
                cargoType = ChosenMaterial;
                Console.WriteLine($"{cargoType} завантажено");
            }
        }
        public void LoadCargoFromStation()
        {
            Console.WriteLine("Введіть тип матеріалу");
            MaterialType cargoType = (MaterialType)Enum.Parse(typeof(MaterialType), Console.ReadLine());

            Console.WriteLine("Введіть загальну вагу матеріалу");
            double Weight = double.Parse(Console.ReadLine());

            if (LoadCapacity == 0)
            {
                double MaxLoad = LoadCapacity;
                switch(cargoType)
                {
                    case MaterialType.Дерево:
                        MaxLoad = 100;
                        break;
                    case MaterialType.Алюміній:
                        MaxLoad = 400;
                        break;
                    case MaterialType.Залізо:
                        MaxLoad = 75;
                        break;
                    case MaterialType.Вугілля:
                        MaxLoad = 75;
                        break;
                    case MaterialType.ВажкіМетали:
                        MaxLoad = 50;
                        break;
                    case MaterialType.Щебінь:
                        MaxLoad = 200;
                        break;
                    case MaterialType.Газ:
                        MaxLoad = 100;
                        break;
                    case MaterialType.ІншийМатеріал:
                        MaxLoad = 100;
                        break;
                }
                if (Weight <= MaxLoad)
                {
                    LoadCapacity = Weight;
                    cargoType = cargoType;
                    Console.WriteLine($"{cargoType} завантажено");
                }
                else
                {
                    Console.WriteLine($"{cargoType} не може перевищувати вантажопідйомність вагона");
                }

            }
            else
            {
                Console.WriteLine("Вагон повинен бути порожнім перед початком завантаження");
            }
        }

        public void UnloadCargoFromStation()
        {
            Console.WriteLine($"Розвантажено {LoadCapacity} тонн");
            LoadCapacity = 0;
            cargoType = MaterialType.ІншийМатеріал;
            OtherMaterial = "";
        }
    }
}
