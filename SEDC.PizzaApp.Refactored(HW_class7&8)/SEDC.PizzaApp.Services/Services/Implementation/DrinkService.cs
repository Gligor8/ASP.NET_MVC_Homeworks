using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Implementation
{
    public class DrinkService : IDrinkMenuService
    {
        private readonly IRepository<Drink> _drinkRepository;

        public DrinkService(IRepository<Drink> drinkRepository)
        {
            //_pizzaRepository = new PizzaRepository();
            _drinkRepository = drinkRepository;
        }
        public Drink GetDrinkFromMenu(string drinkName, DrinkSize size)
        {
            List<Drink> menu = _drinkRepository.GetAll();
            return menu.FirstOrDefault(x => x.Name == drinkName && x.DrinkSize == size);
        }

        public List<string> GetDrinksInMenu()
        {
            return _drinkRepository.GetAll().GroupBy(x => x.Name).Select(x => x.Key).ToList();
        }

        public List<Drink> GetDrinkMenu()
        {
            return _drinkRepository.GetAll();
        }
    }
}
