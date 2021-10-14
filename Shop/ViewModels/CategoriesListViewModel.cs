using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CategoriesListViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        
    }
}