using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17_Polymorphism
{
    class Computer
    {
        public string GraphicCard { get; set; }
        public int Power { get; set; }
        public bool SsdDisk { get; set;  }

        public override string ToString()
        {
            return $"Computer properties:\n  Graphic Card: {GraphicCard}\n  Power: {Power}\n  Disk SSD: {SsdDisk}";
        }
    }
}
