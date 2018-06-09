﻿namespace StorageMaster.Models.Storage
{
    using System.Collections.Generic;
    using StorageMaster.Models.Vehicle;

    public class DistributionCenter : Storage
    {
        public DistributionCenter(string name)
            : base(name, 2, 5, new Vehicle[] { new Van(), new Van(), new Van()})
        {
        }
    }
}
