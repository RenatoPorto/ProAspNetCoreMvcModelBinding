using Microsoft.AspNetCore.Mvc;
using  ProAspNetCoreMvcModelBinding.Repository;

namespace ProAspNetCoreMvcModelBinding.Controllers
{
    public class HomeController : Controller
    {
        
    private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(int id)
        {
            return View("Index", repository[id]);
        }
    }
}

