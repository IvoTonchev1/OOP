using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Exceptions;
using SuperRpgGame.Interfaces;
using SuperRpgGame.Items;

namespace SuperRpgGame.Characters
{
    public class Player : Character, IPlayer
    {
        private List<Item> inventory; 
        public Player(Position position, char objectSymbol, string name, PlayerRace race)
            : base(position, objectSymbol, name, 0, 0)
        {
            this.Race = race;
            this.SetPlayerStats();
            this.inventory = new List<Item>();
        }

        private void SetPlayerStats()
        {
            switch (this.Race)
            {
                case PlayerRace.Alchoholic:
                    this.Damage = 200;
                    this.Health = 200;
                    break;
                case PlayerRace.Archangel:
                    this.Damage = 250;
                    this.Health = 150;
                    break;
                case PlayerRace.Elf:
                    this.Damage = 300;
                    this.Health = 100;
                    break;
                case PlayerRace.Hulk:
                    this.Damage = 300;
                    this.Health = 300;
                    break;
                default:
                    throw new ArgumentException("Unknown player race.");
                    break;
            }
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                    this.Position = new Position(this.Position.X, this.Position.Y - 1);
                    break;
                case "down":
                    this.Position = new Position(this.Position.X, this.Position.Y + 1);
                    break;
                case "right":
                    this.Position = new Position(this.Position.X + 1, this.Position.Y);
                    break;
                case "left":
                    this.Position = new Position(this.Position.X - 1, this.Position.Y);
                    break;
                default:
                    throw new ArgumentException("Invalid direction.", "direction");

            }
        }

        public void Heal()
        {
            var healthPotion = this.inventory.FirstOrDefault() as HealthPotion;
            if (healthPotion == null)
            {
                throw new NotEnoughPotionsException("Not enough health potions.");
            }
            this.Health += healthPotion.HealthRestore;
            this.inventory.Remove(healthPotion);
        }

        public IEnumerable<Item> Inventory
        {
            get { return this.inventory; }
        }

        public void AddItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }

        public PlayerRace Race { get; private set; }
        public override string ToString()
        {
            return string.Format("Player {0} ({1}) Damage: {2}, Health: {3}, Number of items in Inventory: {4}", this.Name, this.Race, this.Damage, this.Health, this.Inventory.Count());
        }
    }
}
