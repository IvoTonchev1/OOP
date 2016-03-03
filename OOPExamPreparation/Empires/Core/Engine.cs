using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Empires.Interfaces;

namespace Empires.Core
{
    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private EmpiresData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory, IResourceFactory resourceFactory, IUnitFactory unitFactory, EmpiresData data, IInputReader reader, IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommand(input);
                this.UpdateBuilding();
            }
        }

        private void UpdateBuilding()
        {
            foreach (IBuilding building in this.data.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resources[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteBuildCommand(string buldingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buldingType, this.unitFactory, this.resourceFactory);
            this.data.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            AppendTreasuryInfo(output);
            AppendBuildingsInfo(output);
            AppendUnitsInfo(output);
            this.writer.Print(output.ToString().Trim());
        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.AppendFormat("--{0}: {1}{2}", unit.Key, unit.Value, Environment.NewLine);
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingsInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (IBuilding building in this.data.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.data.Resources)
            {
                output.AppendFormat("-{0}: {1}{2}", resource.Key, resource.Value, Environment.NewLine);
            }
        }
    }
}
