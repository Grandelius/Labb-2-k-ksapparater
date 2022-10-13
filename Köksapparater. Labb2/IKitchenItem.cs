using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksapparater._Labb2
{
    internal interface IKitchenItem
    {
        string Type { get; set; }
        string Brand { get; set; }
        bool IsFunctioning { get; set; }
        void Use();
    }
}
