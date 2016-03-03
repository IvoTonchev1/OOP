using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;
using Empires.Interfaces;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1;
        private int cyclesCount = 0;
        private string unitType;
        private int unitCycleLength;
        private int resourceCycleLength;
        private ResourceType resourceType;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;
        protected Building(string unitType, int unitCycleLength, ResourceType resourceType, int resourceCycleLength, int resourceQuantity, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.unitCycleLength = unitCycleLength;
            this.resourceType = resourceType;
            this.resourceCycleLength = resourceCycleLength;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
            this.resourceQuantity = resourceQuantity;
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource = this.cyclesCount > ProductionDelay && (this.cyclesCount - ProductionDelay) % this.resourceCycleLength == 0;
                return canProduceResource;
            }
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cyclesCount > ProductionDelay && (this.cyclesCount - ProductionDelay) % this.unitCycleLength == 0;
                return canProduceUnit;
            }
        }

        public IResource ProduceResource()
        {
            var resource = this.resourceFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }
        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }
        public void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLength - (this.cyclesCount - ProductionDelay) % this.unitCycleLength;
            int turnsUntilResource = this.resourceCycleLength - (this.cyclesCount - ProductionDelay) % this.resourceCycleLength;
            var result = string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name, this.cyclesCount - ProductionDelay, turnsUntilUnit, this.unitType, turnsUntilResource, this.resourceType);
            return result;
        }
    }
}
