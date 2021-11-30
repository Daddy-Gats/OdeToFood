using OdeToFood.Data.Models;
using OdeToFood.Data.Servicesamd;
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
            restaurants = new List<Restaurant>();
            //{
            //    new Restaurant { Id = 1, Name = "Magakos Pizza", Cuisine = CuisineType.Italian },
            //    new Restaurant { Id = 2, Name = "O Dikos Sou", Cuisine = CuisineType.Indian },
            //    new Restaurant { Id = 3, Name = "To megalo Aggouri", Cuisine = CuisineType.French }

            //};

        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
           var existing = Get(restaurant.Id); 
            if(existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }
    }
}
