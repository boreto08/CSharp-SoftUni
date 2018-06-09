namespace StorageMaster.Models.Factories
{
    using System;
    using StorageMaster.Models.Vehicle;

    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            Vehicle vehicle;
            switch (type)
            {

                case "Van":
                    vehicle = new Van();
                    break;
                case "Semi":
                    vehicle = new Semi();
                    break;
                case "Truck":
                    vehicle = new Truck();
                    break;
                default:
                    throw new InvalidOperationException("Invalid vehicle type!");
            }

            return vehicle;
        }
    }
}
