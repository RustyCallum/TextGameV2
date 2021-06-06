using System;


namespace TextGameV2
{
    class MainPuzzle
    {
        public static dynamic HeroObj;
        public static dynamic backpackObject;
        public static dynamic HealthPotion;
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?:");
            string heroName = Console.ReadLine();

            Weapon weaponObject = new Weapon();
            Armour armourObject = new Armour();

            backpackObject = new Backpacks();

            armourObject.ArmourName = "Basic armour";

            weaponObject.WeaponName = "Basic weapon";

            HealthPotion = new HealthPotion();

            HeroObj = new Hero();
            HeroObj.Name = heroName;
            HeroObj.armour = armourObject;
            HeroObj.weapon = weaponObject;

            Console.WriteLine("Hello " + HeroObj.Name);
            Console.WriteLine("You wield " + HeroObj.weapon.WeaponName + " and you have " + HeroObj.armour.ArmourName + " on yourself.");

            Map mapObject = new Map();

            while (true)
            {
                Console.WriteLine("Where do you want to go " + HeroObj.Name);
                string WayChoice = Console.ReadLine();
                if (WayChoice == "n")
                {
                    mapObject.GoNorth();
                }
                else if (WayChoice == "s")
                {
                    mapObject.GoSouth();
                }
                else if (WayChoice == "w")
                {
                    mapObject.GoWest();
                }
                else if (WayChoice == "e")
                {
                    mapObject.GoEast();
                }
            }
        }
    }
}
