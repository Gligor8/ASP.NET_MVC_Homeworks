using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Drink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DrinkSize DrinkSize { get; set; }
        public double Price { get; set; }
    }
}
