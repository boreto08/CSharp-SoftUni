namespace StorageMaster.Models.Storage
{

    using System;
    using System.Collections.Generic;
    using StorageMaster.Models.Vehicle;

    public class AutomatedWarehouse : Storage
    {

        public AutomatedWarehouse(string name) 
            : base(name, 1, 2, new Vehicle[] { new Truck()})
        {
        }
    }
}
