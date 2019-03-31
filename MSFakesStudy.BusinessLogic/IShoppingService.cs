using System.Collections.Generic;
using MSFakesStudy.Models;

namespace MSFakesStudy.BusinessLogic
{
    public interface IShoppingService
    {
        List<Good> GetGoodsByName(string name);
    }
}