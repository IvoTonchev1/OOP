using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.Core.Interfaces;

namespace WebPage.Core.ViewEngine
{
    public class ViewResult : IViewResult
    {
        public ViewResult(string viewFullQualifiedName)
        {
            this.Action = (IRenderable) Activator.CreateInstance(Type.GetType(viewFullQualifiedName));
        }

        public IRenderable Action { get; set; }


        public void Invoke()
        {
            this.Action.Render();
        }
    }
}
