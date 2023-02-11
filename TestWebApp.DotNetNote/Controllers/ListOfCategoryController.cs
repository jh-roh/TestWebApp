﻿using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class ListOfCategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public ListOfCategoryController(ICategoryRepository repository)
        {
            _repository = repository;

        }


        public IActionResult Index()
        {
            //var categoryRepository = new CategoryRepositoryInMemory();

            //var categories = categoryRepository.GetCategories();
            var categories = _repository.GetCategories();

            return View(categories);

        }
    }
}
