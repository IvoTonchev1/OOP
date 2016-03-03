using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.Core.Interfaces;
using WebPage.Core.Interfaces.Generic;

namespace WebPage.Core.ViewEngine.Generic
{
    public class ViewResult<T> : IViewResult<T>
    {
        public ViewResult(string viewFullQualifiedName, T model)
        {
            this.Action = (IRenderable<T>)Activator.CreateInstance(Type.GetType(viewFullQualifiedName));
            this.Action.Model = model;
        }

        public IRenderable<T> Action { get; set; }

        public void Invoke()
        {
            this.Action.Render();
        }
    }
}
