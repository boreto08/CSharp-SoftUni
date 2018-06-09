namespace StorageMaster.Models.Factories
{
    using System;
    using StorageMaster.Models.Products;

    public class ProductFactory
    {
        public Product CreateProduct(string type,double price)
        {
            Product product;

            switch (type)
            {
                case "SolidStateDrive ":
                    product = new SolidStateDrive(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "Gpu":
                    product = new Gpu(price);
                    break;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }

            return product;
        }
    }
}
