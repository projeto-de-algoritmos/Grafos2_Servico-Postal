using Microsoft.AspNetCore.Mvc;
using PostalServices.Models;

namespace PostalServices.Controllers
{
    public class CitiesController : Controller
    {
        private readonly Cities _cities;
        
        // GET
        public IActionResult Index()
        {
            // exemplo de chamada do metodo na classe cities que vai fazer o teste do grafo
            _cities.SearchCitiesTest();
            return View();
        }
    }
}