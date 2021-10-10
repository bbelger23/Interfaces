namespace Interfaces.Models
{
    public interface ICombatant 
    {
        public string Name {get;set;}
        public Shield Shield {get;set;}
        public Chainmail Chainmail {get;set;}
        public Axe Axe {get;set;}
        void Attack(ICombatant enemy);
        void Defend(ICombatant enemy);
    }
}