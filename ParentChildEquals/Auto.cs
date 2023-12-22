using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildEquals
{
    public class Auto : Voertuig
    {
        public string Model { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Auto other)
            {
                return base.Equals(other) && this.Model == other.Model;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Model);
        }
    }
}
