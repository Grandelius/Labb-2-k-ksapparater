using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksapparater._Labb2
{
    internal class KitchenItem
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }

        public KitchenItem(string type, string brand, bool isFunctioning)
        {
            Type = type;
            Brand = brand;
            IsFunctioning = isFunctioning;

        }

        public void Use()
        {
            if (IsFunctioning == true)
            {
                Console.WriteLine(Type + " används\n");
            }

            if (IsFunctioning == false)
            {
                Console.WriteLine(Type + " är trasig och kan därför inte användas\n");
            }

        }

        public void PrintItem()
        {
            if (IsFunctioning == true)
            {
                Console.WriteLine(
                    $"Typ: {Type}\n" +
                    $"Märke: {Brand}\n" +
                    $"Skick: Fungerar\n----------");
            }

            else if (IsFunctioning == false)
            {
                Console.WriteLine(
                    $"Typ: {Type}\n" +
                       $"Märke: {Brand}\n" +
                       $"Skick: Trasig\n----------");
            }

        }
    }

}
