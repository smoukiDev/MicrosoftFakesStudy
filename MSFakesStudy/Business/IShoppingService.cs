using System.Collections.Generic;
using MSFakesStudy.Models;

namespace MSFakesStudy.Business
{
    public interface IShoppingService
    {
        List<Good> GetGoodsByName(string name);
    }
}