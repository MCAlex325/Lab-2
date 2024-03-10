namespace Lab_2
{
    public enum MaterialType
    {
        Wood = 100, Metal = 50, Coal = 75, Oil = 100
    }

    public class FreightCarriage : Carriage
    {
        public double Load { get; set; }
        public MaterialType Material { get; set; }
        public string OtherMaterial { get; set; }
        public double Weight { get; set; }


        public FreightCarriage(string id, double loadCapacity, MaterialType material)
            : base(id, "Freight_Carriage")
        {
            Load = 0;
            Material = material;
            OtherMaterial = "";
        }

        public void LoadCargo()
        {
            Console.WriteLine("Виберіть тип матеріалу:");
            foreach (var material in Enum.GetValues(typeof(MaterialType)))
            {
                Console.WriteLine($"{(int)material} - {(string)material}");
            }
            MaterialType chosenMaterial = (MaterialType)Enum.Parse(typeof(MaterialType), Console.ReadLine());

            Console.WriteLine("Введіть вагу вантажу:");
            double cargoWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Вантаж {Material} завантажено.");
        }
        public void StationLoadCargo()
        {
            Console.Write("Введіть тип вантажу: ");
            MaterialType material = (MaterialType)Enum.Parse(typeof(MaterialType), Console.ReadLine());

            Console.Write("Введіть вагу вантажу: ");
            double cargoWeight = double.Parse(Console.ReadLine());
        }
    }
}