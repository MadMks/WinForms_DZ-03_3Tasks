using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_ComponentsOfPc
{
    public class Product
    {
        public string Name { get; set; }
        public string Characteristic { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Name} | {Characteristic} | {Description}";
        }
    }
}
