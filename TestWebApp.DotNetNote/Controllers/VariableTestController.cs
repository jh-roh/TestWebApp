using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class VariableTestController : Controller
    {
        private readonly IVariableRepositoryInMemory _repository;

        public VariableTestController(IVariableRepositoryInMemory repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {
            var variables = _repository.GetAll();

            ViewBag.Variables = variables;

            return View();
        }
    }
}
