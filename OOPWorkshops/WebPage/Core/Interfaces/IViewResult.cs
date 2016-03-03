using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage.Core.Interfaces
{
    public interface IViewResult : IInvokable
    {
        IRenderable Action { get; set; }

    }
}
