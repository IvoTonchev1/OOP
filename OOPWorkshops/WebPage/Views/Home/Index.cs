using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.Core.Interfaces;
using WebPage.Core.Interfaces.Generic;
using WebPage.ViewModels;

namespace WebPage.Views.Home
{
    public class Index : IRenderable
    {
        public void Render()
        {
            Console.WriteLine("MY FIRST VIEW");
        }

    }
}
