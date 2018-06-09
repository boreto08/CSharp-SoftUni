namespace StorageMaster.Models.Products
{
    using System;

    public class HardDrive : Product
    {
        private const double weightHardDrive = 1.0;

        public HardDrive(double price) 
            : base(price, weightHardDrive)
        {
        }
    }
}
