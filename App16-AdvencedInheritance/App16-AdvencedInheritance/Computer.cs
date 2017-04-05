using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16_AdvencedInheritance
{
    class Computer
    {
        public string GraphicCard { get; set; }
        public int Power { get; set; }
        public bool SsdDisk { get; set;  }

        public string ToString()
        {
            return $"Computer properties:\n  Graphic Card: {GraphicCard}\n  Power: {Power}\n  Disk SSD: {SsdDisk}";
        }
    }
}
