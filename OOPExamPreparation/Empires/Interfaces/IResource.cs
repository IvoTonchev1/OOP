using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Interfaces
{
    public interface IResource
    {
        ResourceType ResourceType { get; }
        int Quantity { get; }
    }
}
