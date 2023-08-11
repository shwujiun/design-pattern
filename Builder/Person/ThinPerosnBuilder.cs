using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Person
{
    public  class ThinPerosnBuilder : Builder
    {
        public ThinPerosnBuilder(string graphic, string pen) : base(graphic, pen) { }

        public override void BuildBody()
        {
            
        }

        public override void BuildFoot()
        {
            
        }

        public override void BuildHand()
        {
            
        }

        public override void BuildHead()
        {
            
        }
    }
}
