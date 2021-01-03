using System;

namespace MyClassLib.WordOfTank
{
    public class Tank
    {
        private Random rand;
        public string Name { get; set; }
        public int AmmoLvl
        {
            get
            {
                return ammoLvl;
            }
        }
        public int ArmorLvl
        {
            get
            {
                return ArmorLvl;
            }
        }
        public int ManeuverLvl
        {
            get
            {
                return ManeuverLvl;
            }
        }

        private string name;
        private int ammoLvl;
        private int armorLvl;
        private int maneuverLvl;

        public Tank(string name)
        {
            rand = new Random();
            try
            {
                this.name = name;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            ammoLvl = rand.Next() % 100;
            armorLvl = rand.Next() % 100;
            maneuverLvl = rand.Next() % 100;
        }

        public string GetAmmo()
        {
            return $"{ammoLvl}";
        }
        public string GetArmor()
        {
            return $"{armorLvl}";
        }
        public string GetManeuver()
        {
            return $"{maneuverLvl}";
        }

        public static bool operator *(Tank tank, Tank tank2)
        {
            bool ammo = false;
            bool armor = false;
            bool maneuver = false;
            if (tank.ammoLvl > tank2.ammoLvl)
            {
                ammo = true;
            }
            if (tank.armorLvl > tank2.armorLvl)
            {
                armor = true;
            }
            if (tank.maneuverLvl > tank2.maneuverLvl)
            {
                maneuver = true;
            }
            if ((ammo && armor) || (ammo && maneuver) || (armor && maneuver) || (armor && ammo && maneuver))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
