namespace Interfaces.Models
{
    public class Fighter : ICombatant
    {
        public string Name {get;set;}
        public Shield Shield {get;set;}
        public Chainmail Chainmail {get;set;}
        public Bow Bow {get;set;}
        public Axe Axe {get;set;}
        

        public Fighter() 
        {
            Name = "Elf";
            Chainmail = new Chainmail();
            Bow = new Bow();
        }

        public void Attack(ICombatant enemy) 
        {
            if (Bow.Power > enemy.Shield.Defense) {
                System.Console.WriteLine($"{Name} attacks {enemy.Name} with his {Bow.Name}");
            }
            else {
                System.Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Shield.Name}"); 
            }
        }

        public void Defend(ICombatant enemy) 
        {
            if (enemy.Axe.Power > Chainmail.Defense) {
                System.Console.WriteLine($"{enemy.Name} attacks {Name} with his {Axe.Name}");
            }
            else {
                System.Console.WriteLine($"{Name} blocks {enemy.Name} with his {Chainmail.Name}"); 
            }
        }
    }
}