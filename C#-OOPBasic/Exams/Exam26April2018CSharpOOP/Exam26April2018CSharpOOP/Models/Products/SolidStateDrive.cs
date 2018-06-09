namespace StorageMaster.Models.Products
{
    using System;

    public class SolidStateDrive : Product
    {
        private const double weightSolidStateDrive = 0.2;

        public  SolidStateDrive(double price) 
            : base(price, weightSolidStateDrive)
        {
        }
    }
}
