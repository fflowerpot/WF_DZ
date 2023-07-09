using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ._24._09._2023
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalculateTotalPrice()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Total_Price: {CalculateTotalPrice()}";
        }
        public void SaveAsFile(string filePath)
        {
            string productData = $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
            File.WriteAllText(filePath, productData);
        }
    }
}
