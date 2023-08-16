

//Bridge 將抽象部分與他的實現部分分離，使他們都可以獨立地變化
using Bridge;

HandM hand = new HandM();
HandsetSoft soft = new Game();
hand.SetHandSoft(soft);
hand.Run();


Abstraction  ab = new RefinedAbstraction();
ab.SetImplementor(new ConcreteImplementorA());
ab.Operation();
abstract class HandsetSoft
{
    public abstract void Run();
}

class Game : HandsetSoft
{
    public override void Run()
    {
        Console.WriteLine("執行手機遊戲");
    }
}


abstract class HandBrand
{
    protected HandsetSoft soft;    

    
    public void SetHandSoft(HandsetSoft soft)
    {
        this.soft = soft;
    }
    public abstract void Run();
}

class HandM : HandBrand
{
    
    public override void Run()
    {   
        soft.Run();
            
        
    }
}




