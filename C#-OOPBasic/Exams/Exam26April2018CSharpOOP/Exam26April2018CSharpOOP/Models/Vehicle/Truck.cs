namespace StorageMaster.Models.Vehicle
{
    public class Truck : Vehicle
    {
        private const int capacityTruck = 5;

        public Truck() 
            : base(capacityTruck)
        {
        }
    }
}
