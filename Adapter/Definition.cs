using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Target
{
    public virtual void Request()
    {
        Console.WriteLine("普通請求");
    }
}

class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("特殊請求");
    }
}

class Adatper : Target
{
    private Adaptee adaptee = new Adaptee();
    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

