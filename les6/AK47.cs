using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les6
{
    public class AK47 : FireArm
    {
        private int ManufacturingYear;

        public AK47(int year) : base(30, 5) 
        {
            ManufacturingYear = year;
        }

        public int GetManufacturingYear()
        {
            return ManufacturingYear;
        }

        public override void Reload()
        {
            Loaded = AmmunitionCapacity;
            Console.WriteLine("AK-47 Reloaded");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AK47 ak47 = new AK47(2020);
            Bow bow = new Bow("Longbow", "Wooden Arrow");

            Console.WriteLine($"AK-47 Shoot Damage: {ak47.Shoot()}");
            Console.WriteLine($"AK-47 Manufacturing Year: {ak47.GetManufacturingYear()}");


            Console.WriteLine($"Bow Shoot Damage: {bow.Shoot()}");
            bow.SwapArrow("Steel Arrow");
            Console.WriteLine($"Bow Shoot Damage with new arrow: {bow.Shoot()}");
        }
    }
}
