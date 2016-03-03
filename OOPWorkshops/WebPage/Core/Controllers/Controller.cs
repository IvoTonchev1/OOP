using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebPage.Core.Interfaces;
using WebPage.Core.Interfaces.Generic;
using WebPage.Core.ViewEngine;
using WebPage.Core.ViewEngine.Generic;

namespace WebPage.Core.Controllers
{
    public class Controller
    {
        protected IViewResult View([CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace("Controller", "");
            string fullQualifiedName = MvcContext.Current.AssemblyName + "." + MvcContext.Current.ViewsFolder + "." +
                                       controllerName + "." + callee;
            return new ViewResult(fullQualifiedName);
        }

        protected IViewResult View(string controller, string action)
        {
            string fullQualifiedName = MvcContext.Current.AssemblyName + "." + MvcContext.Current.ViewsFolder + "." +
                                       controller + "." + action;
            return new ViewResult(fullQualifiedName);
        }

        protected IViewResult<T> View<T>(T model, [CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace("Controller", "");
            string fullQualifiedName = MvcContext.Current.AssemblyName + "." + MvcContext.Current.ViewsFolder + "." +
                                       controllerName + "." + callee;
            return new ViewResult<T>(fullQualifiedName, model);
        }
        protected IViewResult<T> View<T>(T model, string controller, string action)
        {
            string fullQualifiedName = MvcContext.Current.AssemblyName + "." + MvcContext.Current.ViewsFolder + "." +
                                       controller + "." + action;
            return new ViewResult<T>(fullQualifiedName, model);
        }
    }
}
