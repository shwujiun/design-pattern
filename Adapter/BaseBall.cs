using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Player
{
    public string name;
    public Player(string name)
    {
        this.name = name;
    }

    public abstract void Attack();
}

class Forwards : Player
{
    public Forwards(string name) : base(name) { }
    public override void Attack()
    {
        Console.WriteLine("前鋒進攻");
    }
}

class Center : Player
{
    public Center(string name) : base(name) { }
    public override void Attack()
    {
        Console.WriteLine("中鋒進攻");
    }
}

class Guard : Player
{
    public Guard(string name) : base(name) { }  
    public override void Attack()
    {
        Console.WriteLine("後衛進攻");
    }
}


class Foreigner
{
    public string name { get; set; }
    public void 進攻()
    {
        Console.WriteLine("外國人進攻");
    }
}

class Translator : Player
{
    public Translator(string name):base(name) { }   
    private Foreigner f = new Foreigner();
    public override void Attack()
    {
        f.進攻();
    }
}