using System;

namespace CandyShop.Core.Models
{
    public sealed class Sweetness : DataBaseUnit, IEntity
    {
        public string Name{ get; set; }
        public float Weight { get; set; }
        public int Calories { get; set; }
        public string ShelfLife { get; set; }
        public SweetnessCategory SweetnessCategory { get; set; }
    }
}
