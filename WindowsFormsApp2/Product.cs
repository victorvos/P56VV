using System;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class Product
    {
        private String name;
        private double price;
        private int amount;
        private static List<Product> productsStore = new List<Product>(); //producten lijst in store.

        public Product(String name, Double price)
        {
            this.name = name;
            this.price = price;
            productsStore.Add(this);
        }

        public String Name { get; set; }
        public Double Price { get; set; }
        public int Amount { get; set; }
    }
}
