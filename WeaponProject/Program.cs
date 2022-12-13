using System.ComponentModel.Design;
using WeaponProject.Models;

namespace WeaponProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int remain = 0;
            int emptyTime = 0 ;
            string mode = "";
            int? option;
            Weapon weapon = new Weapon(capacity, remain, emptyTime, mode);
            Menu:
            Console.WriteLine("0 - Menu\n1- Shoot\n2-Fire\n3-Get remaining bullets\n4-Reload\n5- Change fire mode\n6-quit");
            while (true)
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option != null && option >=0 && option <=6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            switch (option)
            {
                case 0:
                    goto Menu;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.Fire();
                    break;
                case 3:
                    weapon.GetRemainBulletCount();
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
                case 6:
                    Console.WriteLine("Program ended.");
                    break;
                default:
                    break;
            }
        }

    }
}