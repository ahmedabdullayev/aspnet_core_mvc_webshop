using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Electric cars", desc = "Modern transport"},
                    new Category{ categoryName = "Classic cars", desc = "Cars with benzine engine"}
                };
            }
        }
    }
}