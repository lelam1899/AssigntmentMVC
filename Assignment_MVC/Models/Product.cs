using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public int Views { get; set; }

        public virtual Category Category { get; set; }
    }
}