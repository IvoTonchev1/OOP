using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;
using Empires.Interfaces;
using Empires.Models;

namespace Empires.Core.Factories
{
    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(resourceType, quantity);
            return resource;
        }
    }
}
