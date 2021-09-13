using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess
{
    public static class StaticDb
    {
        public static List<Order> Orders;
        public static List<User> Users;
        public static List<Pizza> Menu;
        public static List<Drink> DrinkMenu;
        public static List<Feedback> Feedbacks;

        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Martin",
                    LastName = "Jankuloski",
                    Address = "Street 01",
                    Phone = 38977123456
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address = "Unknown",
                    Phone = 38977654321
                }
            };

            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Price = 250,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Pepperoni",
                    Price = 350,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Margherita",
                    Price = 200,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Margherita",
                    Price = 240,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 7,
                    Name = "Margherita",
                    Price = 280,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "Capri",
                    Price = 200,
                    Size = PizzaSize.Medium
                }
            };

            DrinkMenu = new List<Drink>()
            {
                new Drink()
                {
                    ID = 2,
                    Name = "CocaCola - cane",
                    DrinkSize = DrinkSize.zeroPointFive,
                    Price = 0.70,
                },

                new Drink()
                {
                    ID = 3,
                    Name = "RedBull",
                    DrinkSize = DrinkSize.zeroPointThirtyThree,
                    Price = 1.00,
                },

                new Drink()
                {
                    ID = 4,
                    Name = "Skopsko - Panache",
                    DrinkSize = DrinkSize.zeroPointFive,
                    Price = 0.90,
                },

                new Drink()
                {
                    ID = 4,
                    Name = "Sprite",
                    DrinkSize = DrinkSize.two,
                    Price = 1.99,
                }
            };

            Orders = new List<Order>()
            {
                new Order()
                {
                    OrderId = 1,
                    User = Users[0],
                    PizzaOrders = new List<PizzaOrder> { new PizzaOrder { Pizza = Menu[0] } },
                    DeliveryPrice = 40,
                    IsDelivered = false
                },
                new Order()
                {
                    OrderId = 2,
                    User = Users[1],
                    PizzaOrders = new List<PizzaOrder> { new PizzaOrder { Pizza = Menu[3] } },
                    DeliveryPrice = 30,
                    IsDelivered = true
                }
            };

            Feedbacks = new List<Feedback>();
        }
    }
}
