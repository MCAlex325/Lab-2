namespace Lab_2
{
    public enum MaterialType
    {
        Wood = 1, Aluminium = 2, Iron = 3, Coal = 4, HeavyMetal = 5, Grain = 6,
    }
    public class FreightCarriage : Carriage
    {
        public double maxLoadCapacity {  get; set; }
        public MaterialType cargoType {  get; set; }
        public string Weight {  get; set; }

        public FreightCarriage(string ID, MaterialType cargoType) : base(ID, "Freight")
        {
            maxLoadCapacity = 0;
            cargoType = MaterialType.Wood;
        }

    }
}
