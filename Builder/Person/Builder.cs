using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Person
{
    public abstract class Builder
    {
        protected string Graphics = "";
        protected string Pen = "";

        public Builder(string graphics, string pen)
        {
            Graphics = graphics;
            Pen = pen;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildHand();
        public abstract void BuildFoot();
    }
}
