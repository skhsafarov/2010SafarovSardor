using System;
using System.Collections.Generic;
using System.Text;

namespace VegetableWarehouse
{
    class Box
    {
        // Масса.
        public double Weight { get; set; }
        // Стоимость.
        public double PricePerKg { get; set; }
        // Переопределение метода ту стринг.
        public override string ToString()
        {
            return $"\tмасса: {Weight}\n\tцена: {PricePerKg}";
        }
    }
}
