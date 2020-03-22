using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.SharedKernel.Interfaces;
using CleanArchitecture.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public HomeController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }


        public IActionResult Index()
        {
            var items = _categoriesRepository.GetAll<Categories>().
                Select(CategoriesDTO.FromCategories);

            return View(items);
        }
    }
}