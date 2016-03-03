using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.BindingModels;
using WebPage.Core.Attributes.HttpRequestMethods;
using WebPage.Core.Controllers;
using WebPage.Core.Interfaces;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IViewResult Index(int id, IndexBindingModel model)
        {
            return View();
        }
    }
}
