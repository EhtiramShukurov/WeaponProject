using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject.Models
{
    internal class Weapon
    {
        int _bulletCapacity;
        int _remainingBulletCount;
        int _bulletEmptyTime;
        string _fireMode;
        public int BulletCapacity
        {
            get { return _bulletCapacity; }
            set
            {
                _bulletCapacity = SetCapacity(value);
            }
        }
        public int RemainingBulletCount
        {
            get { return _remainingBulletCount; }
            set { _remainingBulletCount = SetRemain(value); }
        }
        public int BulletEmptyTime
        {
            get { return _bulletEmptyTime; }
            set { _bulletEmptyTime = SetEmptyTime(value); }
        }
        public string FireMode
        {
            get { return _fireMode; }
            set { _fireMode =SetFireMode(value); }
        }

        public void Shoot()
        {
            if (RemainingBulletCount > 0)
            {
                RemainingBulletCount -= 1;
                Console.WriteLine("Shot one bullet.");
            }
            else
            {
                Console.WriteLine("Comb is empty.");
                return;
            }
        }
        public void Fire()
        {
            if (RemainingBulletCount > 0)
            {
                if (FireMode == "auto")
                {
                    int time = RemainingBulletCount * BulletEmptyTime / BulletCapacity;
                    RemainingBulletCount = 0;
                    Console.WriteLine($"Comb fully emptied in {time} seconds.");
                }
                else
                {
                    RemainingBulletCount -= 1;
                    Console.WriteLine("Fire mode is single,shot one bullet.");

                }
            }
            else
            {
                Console.WriteLine("Comb is empty.");
                return;
            }

        }
        public int GetRemainBulletCount()
        {
            return BulletCapacity - RemainingBulletCount;
        }
        public void Reload()
        {
            _remainingBulletCount = _bulletCapacity;
            Console.WriteLine("Comb reloaded.");
            return;

        }
        public void ChangeFireMode()
        {
            if (FireMode == "auto")
            {
                Console.WriteLine("Fire mode was auto,changed to single.");
                FireMode = "single";
            }
            else
            {
                Console.WriteLine("Fire mode was single, changed to automatic.");
                FireMode = "auto";
            }
            return;

        }
        public Weapon(int bulletCapacity,int remainingBulletCount, int bulletEmptyTime,string fireMode)
        {
            BulletCapacity = bulletCapacity;
            RemainingBulletCount = remainingBulletCount;
            BulletEmptyTime = bulletEmptyTime;
            FireMode = fireMode;
        }
        public  int SetCapacity(int value)
        {
            Console.Write("Enter comb capacity ");
            while (true)
            {
                string str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                {
                    int.TryParse(str, out value);
                    if (value >= 0 && value <= 1000)
                    {
                        return value;
                    }
                    Console.WriteLine("Wrong input,enter again");
                }
                else
                {
                    Console.WriteLine("Wrong input,enter again");
                }
            }
        }
        public int SetRemain(int value)
        {
            Console.Write("Enter remaining bullets ");
            while (true)
            {
                string str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                {
                    int.TryParse(str, out value);
                    if (value >= 0  && value <= BulletCapacity)
                    {
                        return value;
                    }
                    Console.WriteLine("Wrong input,enter again");
                }
                else
                {
                    Console.WriteLine("Wrong input,enter again");
                }
            }
        }
        public int SetEmptyTime(int value )
        {
            Console.Write("Enter empty time ");
            while (true)
            {
                string str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                {
                    int.TryParse(str, out value);
                    if (value > 0)
                    {
                        return value;
                    }
                    Console.WriteLine("Wrong input,enter again");
                }
                else
                {
                    Console.WriteLine("Wrong input,enter again");
                }
            }
        }
        public string SetFireMode(string value)
        {
            Console.Write("Enter fire mode auto/single ");
            string str;
            while (true)
            {
                str = Console.ReadLine();
                str = str.Trim().ToLower();
                if (!String.IsNullOrEmpty(str))
                {
                    if (str == "auto" || str == "single")
                    {
                        return str;
                    }
                    Console.WriteLine("Wrong input,enter again");
                }
                else
                {
                    Console.WriteLine("Wrong input,enter again");
                }
            }
        }
    }
}
