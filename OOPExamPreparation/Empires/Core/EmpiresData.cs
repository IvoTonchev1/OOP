using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;
using Empires.Interfaces;

namespace Empires.Core
{
    public class EmpiresData :IEmpiresData
    {
        private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        public EmpiresData()
        {
            this.Resources = new Dictionary<ResourceType, int>();
            this.InitResources();
            this.Units = new Dictionary<string, int>();
        }

        public IEnumerable<IBuilding> Buildings
        {
            get { return this.buildings; }
        }
        public IDictionary<ResourceType, int> Resources { get; private set; }
        public IDictionary<string, int> Units { get; private set; }
        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException("building");
            }
            this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException("building");
            }
            var unitType = unit.GetType().Name;
            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }
            this.Units[unitType]++;
        }
        private void InitResources()
        {
            foreach (ResourceType resourceType in Enum.GetValues(typeof(ResourceType)))
            {
                this.Resources.Add(resourceType, 0);
            }
        }
    }
}
