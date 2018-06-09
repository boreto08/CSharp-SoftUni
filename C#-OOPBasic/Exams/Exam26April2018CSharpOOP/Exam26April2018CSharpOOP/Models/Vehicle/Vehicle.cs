namespace StorageMaster.Models.Vehicle
{
    using System;
    using StorageMaster.Models.Products;
    using System.Collections.Generic;

    public abstract class Vehicle
    {
        private bool isFull;
        private bool isEmpty;
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        

        public bool IsFull
        {
            get { return this.isFull; }
            private set
            {
                double weight = 0.0;

                foreach (var product in this.Trunk)
                {
                    weight += product.Weight;
                }

                if (weight >= this.Capacity)
                {
                    value = true;
                }
                else
                {
                    value = false;
                }

                this.isFull = value;
            }
        }

        public bool IsEmpty
        {
            get { return this.isEmpty; }

            private set
            {
                if (this.Trunk.Count == 0)
                {
                    value = true;
                }
                else
                {
                    value = false;
                }

                isEmpty = value;
            }
        }

        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException(ErrorMessages.VehicleIsFullExeption);
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException(ErrorMessages.NoProductsLeftInVehicleExeption);
            }

            Product product = trunk[trunk.Count - 1];
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }

    }
}
