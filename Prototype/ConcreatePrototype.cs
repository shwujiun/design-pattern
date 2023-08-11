using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class ConcreatePrototype : Prototype
    {
        public ConcreatePrototype(string id):base(id) { }
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
            //return (Prototype)this.MemberwiseClone();
        }
    }
}
