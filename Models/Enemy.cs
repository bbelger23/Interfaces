namespace Interfaces.Models
{
    public class Enemy : ICombatant
    {
        public string Name {get;set;}
        public Chainmail Chainmail {get;set;}
        public Shield Shield {get;set;}
        public Axe Axe {get;set;}

        public Enemy() 
        {
            Name = "Troll";
            Shield = new Shield();
            Axe = new Axe();
        }
        public void Attack(ICombatant enemy) 
        {
           
        }

        public void Defend(ICombatant enemy) {
            
        }
    }
}