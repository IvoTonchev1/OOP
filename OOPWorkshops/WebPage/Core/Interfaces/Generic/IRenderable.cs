using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage.Core.Interfaces.Generic
{
    public interface IRenderable<T> : IRenderable
    {
        T Model { get; set; }
    }
}
