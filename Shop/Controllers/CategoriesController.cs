using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICarsCategory _carsCategory;

        public CategoriesController(ICarsCategory carsCategory)
        {
            _carsCategory = carsCategory;
        }

        public ViewResult List()
        {
            CategoriesListViewModel obj = new CategoriesListViewModel();
            obj.Categories = _carsCategory.AllCategories;
            return View(obj);
        }
    }
}