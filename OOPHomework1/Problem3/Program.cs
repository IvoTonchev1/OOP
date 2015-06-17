using System;
using System.Collections.Generic;
using System.Text;
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            List<Component> components = new List<Component>();
            components.Add(new Component("Motherboard", 90));
            components.Add(new Component("CPU", 120.45m));
            components.Add(new Component("RAM", 45.50m, "8 GB"));

            Computer pc = new Computer("HP", components);
            Console.WriteLine(pc);
            pc.AddComponent(new Component("added later", 1));
            Console.WriteLine(pc);

            List<Computer> catalog = new List<Computer>();
            catalog.Add(pc);

            List<Component> componentsList4 = new List<Component>();
            componentsList4.Add(new Component("GPU", 1125.5m));
            componentsList4.Add(new Component("CPU", 900));

            catalog.Add(new Computer("Expensive", componentsList4));

            List<Component> componentsList2 = new List<Component>();
            componentsList2.Add(new Component("DVD", 15.99m));
            componentsList2.Add(new Component("GPU", 255.1m));

            catalog.Add(new Computer("Cheap", componentsList2));

            List<Component> componentsList3 = new List<Component>();
            componentsList3.Add(new Component("RAM", 52.19m));
            componentsList3.Add(new Component("SSD", 550));

            catalog.Add(new Computer("Average", componentsList3));

            catalog.Sort();

            foreach (var computer in catalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
