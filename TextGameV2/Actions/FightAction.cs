using System;
using TextGameV2.Domain.Characters;
using TextGameV2.Domain.Items;

namespace TextGameV2.Actions
{
    public class FightAction : IFightAction
    {
        public void Fight(Hero hero, Monster monster)
        {
            Console.WriteLine("You are fighting with " + monster.Name);
            while (monster.Health > 0)
            {
                var rd = new Random();
                var MonsterAction = rd.Next(0, 3);
                if (MonsterAction == 0)
                {
                    Console.WriteLine(monster.Name + " is going to attack!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory e = Current hero equipment");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();

                    if (PlayerAction == "a")
                    {
                        monster.DamageTaken = hero.Weapon.AttackDamage;
                        monster.TakeDamage();
                        hero.DamageTaken = monster.AttackDamage;
                        hero.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        hero.DamageTaken = monster.AttackDamage - hero.Armour.ArmourAmount;
                        hero.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "i")
                    {
                        Console.WriteLine(hero.Backpack.Name);
                        hero.Backpack.ListItems();
                    }
                    else if (PlayerAction == "e")
                    {
                        hero.ShowEquipment();
                    }

                }
                else if (MonsterAction == 1)
                {
                    Console.WriteLine(monster.Name + " is going to defend!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory e = Current hero equipment");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        monster.DamageTaken = hero.Weapon.AttackDamage - monster.Armour;
                        monster.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        Console.WriteLine("Nothing happened!");
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "i")
                    {
                        Console.WriteLine(hero.Backpack.Name);
                        hero.Backpack.ListItems();
                    }
                    else if (PlayerAction == "e")
                    {
                        hero.ShowEquipment();
                    }
                }
                else if (MonsterAction == 2)
                {
                    Console.WriteLine(monster.Name + " is going to do nothing now!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory e = Current hero equipment");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        monster.DamageTaken = hero.Weapon.AttackDamage;
                        monster.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        Console.WriteLine("Nothing happened!");
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "i")
                    {
                        Console.WriteLine(hero.Backpack.Name);
                        hero.Backpack.ListItems();
                    }
                    else if (PlayerAction == "e")
                    {
                        hero.ShowEquipment();
                    }
                }
                else if (MonsterAction == 3)
                {
                    Console.WriteLine("You don't know what " + monster.Name + " is going to do!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory e = Current hero equipment");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        monster.DamageTaken = hero.Weapon.AttackDamage;
                        monster.TakeDamage();
                        hero.DamageTaken = monster.AttackDamage;
                        hero.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        hero.DamageTaken = monster.AttackDamage - hero.Armour.ArmourAmount;
                        hero.TakeDamage();
                        Console.WriteLine(monster.Name + " has " + monster.Health + " health!");
                        hero.DisplayHealth();
                    }
                    else if (PlayerAction == "i")
                    {
                        Console.WriteLine(hero.Backpack.Name);
                        hero.Backpack.ListItems();
                    }
                    else if (PlayerAction == "e")
                    {
                        hero.ShowEquipment();
                    }
                }

                if (monster.Health <= 0)
                {
                    monster.GiveReward();
                    Console.WriteLine("Good job! You killed " + monster.Name + " and you got " + monster.AmountOfReward + " gold");
                    hero.GetReward(monster);
                    hero.Backpack.AddItem(new HealthPotion());
                    break;
                }
            }   
        }
    }
}
