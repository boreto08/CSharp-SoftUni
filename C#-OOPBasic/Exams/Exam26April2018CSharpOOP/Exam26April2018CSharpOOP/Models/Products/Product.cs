﻿namespace StorageMaster.Models.Products
{
    using System;

    public abstract class Product
    {
        private double price;

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0 )
                {
                    throw new InvalidOperationException(ErrorMessages.NegativePriceExeption);
                }

                this.price = value;
            }
        }

        public double Weight { get; set; }
    }
}