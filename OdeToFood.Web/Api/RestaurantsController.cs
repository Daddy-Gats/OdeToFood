using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using OdeToFood.Data.Servicesamd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;


namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        public IEnumerable<Restaurant> Get()
        {
        var model = db.GetAll();
            return model;
        }
    }
}
