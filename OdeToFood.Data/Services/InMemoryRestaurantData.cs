using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData: IRestaurantData
    {

        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Magakos Pizza", Cuisine =CuisineType.Italian},
                new Restaurant {Id = 2, Name = "O Dikos Sou", Cuisine =CuisineType.Indian},
                new Restaurant {Id = 3, Name = "To megalo Aggouri", Cuisine =CuisineType.French}

            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
