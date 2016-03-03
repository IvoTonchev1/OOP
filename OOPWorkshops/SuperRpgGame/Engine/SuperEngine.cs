using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Attributes;
using SuperRpgGame.Characters;
using SuperRpgGame.Exceptions;
using SuperRpgGame.Interfaces;
using SuperRpgGame.Items;

namespace SuperRpgGame.Engine
{
    public class SuperEngine
    {
        private const int MapWidth = 10;
        private const int MapHeight = 10;
        private const int InitialNumberOfEnemies = 10;
        private const int InitialNumberOfItems = 15;
        private  static readonly Random Rand = new Random();
        private readonly IInputReader reader;
        private readonly IRenderer renderer;
        private readonly string[] characterNames = {"Artin","Saria","Elenaril","Myrrh","Tanulia","Uiathen","Chaenath","Alanis","Liluth","Delshandra"};
        private readonly IList<GameObject> characters;
        private readonly IList<GameObject> items;
        private IPlayer player;

        public SuperEngine(IInputReader reader, IRenderer renderer)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.characters = new List<GameObject>();
            this.items = new List<GameObject>();
        }

        public bool IsRunning { get; private set; }
        public void Run()
        {
            this.IsRunning = true;
            var playerName = GetPlayerName();
            PlayerRace race = GetPlayerRace();
            this.player = new Player(new Position(0, 0), 'P', playerName, race);
            this.PopulateEnemies();
            this.PopulateItems();
            
            while (this.IsRunning)
            {
                string command = this.reader.ReadLine();
                try
                {
                    this.ExecuteCommand(command);
                }
                catch (ObjectOutOfBoundsException ox)
                {
                    this.renderer.WriteLine(ox.Message);
                }
                catch (NotEnoughPotionsException px)
                {
                    this.renderer.WriteLine(px.Message);
                }
                catch (Exception ex)
                {
                    this.renderer.WriteLine(ex.Message);
                }
                if (this.characters.Count == 0)
                {
                    this.renderer.WriteLine("You won!");
                    this.IsRunning = false;
                }               
            }
        }

        private void PopulateItems()
        {
            for (int i = 0; i < InitialNumberOfItems; i++)
            {
                Item potion = this.CreateItem();
                this.items.Add(potion);
            }
        }

        private void PopulateEnemies()
        {
            for (int i = 0; i < InitialNumberOfEnemies; i++)
            {
                GameObject enemy = this.CreateEnemy();
                this.characters.Add(enemy);
            }
        }

        private Item CreateItem()
        {
            int currentX = Rand.Next(1, MapWidth);
            int currentY = Rand.Next(1, MapHeight);
            bool containsEnemy = this.characters.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            bool containsItem = this.items.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            while (containsEnemy || containsItem)
            {
                currentX = Rand.Next(1, MapWidth);
                currentY = Rand.Next(1, MapHeight);
                containsEnemy = this.characters.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
                containsItem = this.items.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            }
            int potionType = Rand.Next(0, 3);
            PotionSize potionSize;
            switch (potionType)
            {
                case 0:
                    potionSize = PotionSize.Small;
                    break;
                case 1:
                    potionSize = PotionSize.Medium;
                    break;
                case 2:
                    potionSize = PotionSize.Large;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("potionType", "Invalid potion size.");
            }
            return new HealthPotion(new Position(currentX, currentY), potionSize);
        }

        private PlayerRace GetPlayerRace()
        {
            this.renderer.WriteLine("Choose a race:");
            this.renderer.WriteLine("1. Elf (damage: 300, health: 100)");
            this.renderer.WriteLine("2. Archangel (damage: 250, health: 150)");
            this.renderer.WriteLine("3. Alchoholic (damage: 200, health: 200)");
            this.renderer.WriteLine("4. Hulk (damage: 300, health: 300)");
            string choice = this.reader.ReadLine();
            string[] validChoices = {"1", "2", "3", "4"};
            while (!validChoices.Contains(choice))
            {
                this.renderer.WriteLine("Invalid choice! Plesae choose again:");
                choice = this.reader.ReadLine();
            }
            PlayerRace race = (PlayerRace) int.Parse(choice);
            return race;
        }

        private string GetPlayerName()
        {
            this.renderer.WriteLine("Please enter your name:");
            string playerName = this.reader.ReadLine();
            while (string.IsNullOrWhiteSpace(playerName))
            {
                this.renderer.WriteLine("Player name cannot be empty. Please reenter your name:");
                playerName = this.reader.ReadLine();
            }
            return playerName;
        }

        private GameObject CreateEnemy()
        {
            int currentX = Rand.Next(1, MapWidth);
            int currentY = Rand.Next(1, MapHeight);
            bool containsEnemy = this.characters.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            while (containsEnemy)
            {
                currentX = Rand.Next(1, MapWidth);
                currentY = Rand.Next(1, MapHeight);
                containsEnemy = this.characters.Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            }
            int nameIndex = Rand.Next(0, characterNames.Length);
            string name = characterNames[nameIndex];
            var enemyTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(EnemyAttribute))).ToArray();
            var type = enemyTypes[Rand.Next(0, enemyTypes.Length)];
            GameObject character = Activator.CreateInstance(type, new Position(currentX, currentY), name) as GameObject;
            return character;
        }
        private void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "help":
                    ExecuteHelpCommand();
                    break;
                case "map":
                    this.PrintMap();
                    break;
                case "left":
                case "right":
                case "up":
                case "down":
                    this.MovePlayer(command);                   
                    break;
                case "heal":
                    this.player.Heal();
                    this.renderer.WriteLine("Healed!");
                    break;
                case "status":
                    this.ShowStatus();
                    break;
                case "clear":
                    this.renderer.Clear();
                    break;
                case "exit":
                    this.IsRunning = false;
                    this.renderer.WriteLine("Bye, sucker!");
                    break;
                default:
                    throw new ArgumentException("Unknown command", "command");
            }
        }

        private void ShowStatus()
        {
            this.renderer.WriteLine(this.player.ToString());
            this.renderer.WriteLine("Number of enemies left: {0}", this.characters.Count);
        }

        private void MovePlayer(string command)
        {
            this.player.Move(command);
            ICharacter enemy =
                this.characters.Cast<ICharacter>().FirstOrDefault(
                    e => e.Position.X == this.player.Position.X && e.Position.Y == this.player.Position.Y && e.Health > 0);
            if (enemy != null)
            {
                this.EnterBattle(enemy);
            }
            Item item =
                this.items.Cast<Item>().FirstOrDefault(
                    e => e.Position.X == this.player.Position.X && e.Position.Y == this.player.Position.Y && e.ItemState == ItemState.Available);
            if (item != null)
            {
                this.player.AddItemToInventory(item);
                item.ItemState = ItemState.Collected;
                this.renderer.WriteLine("Potion collected.");
            }
        }

        private void EnterBattle(ICharacter enemy)
        {
            this.player.Attack(enemy);
            if (enemy.Health <= 0)
            {
                this.renderer.WriteLine("Enemy killed!");
                this.characters.Remove(enemy as GameObject);
                return;
            }
            enemy.Attack(this.player);
            if (this.player.Health <= 0)
            {
                this.renderer.WriteLine("You died!");
                this.IsRunning = false;
            }
        }

        private void PrintMap()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < MapHeight; i++)
            {
                for (int j = 0; j < MapWidth; j++)
                {
                    if (this.player.Position.X == j && this.player.Position.Y == i)
                    {
                        sb.Append('P');
                        continue;
                    }
                    var character = this.characters.Cast<ICharacter>().FirstOrDefault(c => c.Position.X == j && c.Position.Y == i && c.Health > 0);
                    var item = this.items.Cast<Item>().FirstOrDefault(c => c.Position.X == j && c.Position.Y == i && c.ItemState == ItemState.Available);
                   
                    if (character == null && item == null)
                    {
                        sb.Append(".");
                    }
                    else if (character != null)
                    {
                        var ch = character as GameObject;
                        sb.Append(ch.ObjectSymbol);
                    }
                    else
                    {
                        sb.Append(item.ObjectSymbol);
                    }                    
                }
                sb.AppendLine();
            }
            this.renderer.WriteLine(sb.ToString());
        }

        private void ExecuteHelpCommand()
        {
            string helpInfo = File.ReadAllText("../../HelpInfo.txt");
            this.renderer.WriteLine(helpInfo);
        }
    }
}
