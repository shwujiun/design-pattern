using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Implementor
    {
        public abstract void Operation();
    }

    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具體實現A的方式");
        }
    }
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具體實現B的方式");
        }
    }

    class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }

    class RefinedAbstraction : Abstraction { 
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction ");
            implementor.Operation();
        }
    }

    
}
