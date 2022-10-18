using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Shop.Models
{
    public class ModelShop
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public ModelShop(Shop product)
        {
            Id = product.Id;
            Product = product.Product;
            Quantity = product.Quantity;
            Cost = product.Cost;
        }
    }
}