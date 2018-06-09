﻿

namespace StorageMaster.Models.Storage
{
    using StorageMaster.Models.Vehicle;

    public class Warehouse : Storage
    {
        public Warehouse(string name) 
            : base(name, 10, 10, new Vehicle[] { new Semi(),new Semi(), new Semi() })
        {
        }
    }
}
