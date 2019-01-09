using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App33_LinqExpressions
{
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString()
        {
            return string.Format("Name: {0}, Descritpion: {1}, NumberInStock: {2}", Name, Description, NumberInStock);
        }
    }
}
