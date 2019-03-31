using MSFakesStudy.DataAccess;
using MSFakesStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSFakesStudy.BusinessLogic
{
    public class ShoppingService : IShoppingService
    {
        private readonly ShopDbContext _shopDbContext;

        public ShoppingService()
        {
            _shopDbContext = new ShopDbContext();
        }

        public List<Good> GetGoodsByName(string name)
        {
            var result = _shopDbContext.GetGoodsByName(name);
            return result;
        }
    }
}