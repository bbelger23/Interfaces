using System;
using Interfaces.Models;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Fighter (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            Fighter fighter = new Fighter();
            fighter.Chainmail.Defense = 9;
            fighter.Bow.Power = 7;

            // Create Enemy (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            Enemy enemy = new Enemy();
            enemy.Shield.Defense = 8;
            enemy.Axe.Power = 8;

            // Attack Enemy (execute method)
            fighter.Attack(enemy);
            fighter.Defend(enemy);

            //IMonster monster = null;
            //monster.Roar();

        }
    }
}
