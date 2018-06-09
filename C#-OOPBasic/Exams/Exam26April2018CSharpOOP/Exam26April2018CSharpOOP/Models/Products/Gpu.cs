namespace StorageMaster.Models.Products
{
    using System;

    public class Gpu : Product
    {
        private const double weightGpu = 0.7;

        public Gpu(double price) 
            : base(price, weightGpu)
        {
        }
    }
}
