using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildEquals
{
    public class Voertuig
    {
        public string Merk { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Voertuig other)
            {
                return this.Merk == other.Merk;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Merk);
        }
    }
}
