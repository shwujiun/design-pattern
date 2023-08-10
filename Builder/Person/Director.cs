using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Person
{
    internal class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void  createPerson()
        {
            this.builder.BuildFoot();
            this.builder.BuildBody();
            this.builder.BuildHand();
            this.builder.BuildHead();

        }
    }
}
