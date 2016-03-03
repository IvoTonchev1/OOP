using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.BindingModels;
using WebPage.Core.Attributes.HttpRequestMethods;
using WebPage.Core.Controllers;
using WebPage.Core.Interfaces;
using WebPage.Core.Interfaces.Generic;
using WebPage.ViewModels;

namespace WebPage.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IViewResult<StudentViewModel> Edit(int id, StudentBindingModel bindingModel)
        {
            StudentViewModel viewModel = new StudentViewModel();
            viewModel.FullName = bindingModel.FirstName + " " + bindingModel.LastName;
            return View(viewModel);
        }
    }
}
