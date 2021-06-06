using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    class Fighting
    {
        public static dynamic MonsterObj;
        public static void FightingCode()
        {
            RollMonster();
            Console.WriteLine("You are fighting with " + MonsterObj.Name);
            while (MonsterObj.Health > 0)
            {
                var rd = new Random();
                var MonsterAction = rd.Next(0, 3);
                if (MonsterAction == 0)
                {
                    Console.WriteLine(MonsterObj.Name + " is going to attack!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        MonsterObj.DamageTaken = MainPuzzle.HeroObj.weapon.AttackDamage;
                        MonsterObj.TakeDamage();
                        MainPuzzle.HeroObj.DamageTaken = MonsterObj.AttackDamage;
                        MainPuzzle.HeroObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        MainPuzzle.HeroObj.DamageTaken = MonsterObj.AttackDamage - MainPuzzle.HeroObj.armour.ArmourAmount;
                        MainPuzzle.HeroObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }

                }
                else if (MonsterAction == 1)
                {
                    Console.WriteLine(MonsterObj.Name + " is going to defend!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        MonsterObj.DamageTaken = MainPuzzle.HeroObj.weapon.AttackDamage - MonsterObj.Armour;
                        MonsterObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        Console.WriteLine("Nothing happened!");
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                }
                else if (MonsterAction == 2)
                {
                    Console.WriteLine(MonsterObj.Name + " is going to do nothing now!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        MonsterObj.DamageTaken = MainPuzzle.HeroObj.weapon.AttackDamage;
                        MonsterObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        Console.WriteLine("Nothing happened!");
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                }
                else if (MonsterAction == 3)
                {
                    Console.WriteLine("You don't know what " + MonsterObj.Name + " is going to do!");
                    Console.WriteLine("a = Attack d = Defense i = Inventory");
                    Console.WriteLine("What are you going to do?: ");
                    string PlayerAction = Console.ReadLine();
                    if (PlayerAction == "a")
                    {
                        MonsterObj.DamageTaken = MainPuzzle.HeroObj.weapon.AttackDamage;
                        MonsterObj.TakeDamage();
                        MainPuzzle.HeroObj.DamageTaken = MonsterObj.AttackDamage;
                        MainPuzzle.HeroObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                    else if (PlayerAction == "d")
                    {
                        MainPuzzle.HeroObj.DamageTaken = MonsterObj.AttackDamage - MainPuzzle.HeroObj.armour.ArmourAmount;
                        MainPuzzle.HeroObj.TakeDamage();
                        Console.WriteLine(MonsterObj.Name + " has " + MonsterObj.Health + " health!");
                        MainPuzzle.HeroObj.DisplayHealth();
                    }
                }

                if (MonsterObj.Health <= 0)
                {
                    MonsterObj.GiveReward();
                    Console.WriteLine("Good job! You killed " + MonsterObj.Name + " and you got " + MonsterObj.AmountOfReward + " gold");
                    MainPuzzle.HeroObj.GetReward();
                    MainPuzzle.backpackObject.AddItem(MainPuzzle.HealthPotion);
                    break;
                }
            }   
        }

        public static void RollMonster()
        {
            MonsterObj = MonsterFactory.MonsterCreate();
        }
    }
}
