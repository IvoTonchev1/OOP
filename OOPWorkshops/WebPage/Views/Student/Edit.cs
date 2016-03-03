using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WebPage.Core.Interfaces.Generic;
using WebPage.ViewModels;

namespace WebPage.Views.Student
{
    public class Edit : IRenderable<StudentViewModel>
    {
        public StudentViewModel Model { get; set; }


        public void Render()
        {
            Console.WriteLine("AZ SAM EDIT VIEW NA STUDENT");
            Console.WriteLine("MOQT FULL NAME E " + Model.FullName);
        }
    }
}
