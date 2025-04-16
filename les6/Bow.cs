using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les6
{
    public class Bow : IRangedWeapon
    {
        public string Type { get; set; }
        public string LoadedArrow { get; set; }

        public Bow(string type, string loadedArrow)
        {
            Type = type;
            LoadedArrow = loadedArrow;
        }

        public void LoadArrow(string arrow)
        {
            LoadedArrow = arrow;
        }

        public void SwapArrow(string arrow)
        {
            LoadedArrow = arrow;
        }

        public int Shoot()
        {
            if (LoadedArrow != null)
            {
                Console.WriteLine($"Shot {LoadedArrow} arrow");
                return 3; 
            }
            else
            {
                Console.WriteLine("No arrow loaded!");
                return 0;
            }
        }
    }

}
