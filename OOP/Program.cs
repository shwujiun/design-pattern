//抽象(abstract)

using OOP;

Car car = new Car
{
    Brand = "Honda",
    Color = "Blue",
    Speed = 60
};

Console.WriteLine($"建立一台汽車，廠牌：{car.Brand}，顏色：{car.Color}，目前速度：{car.Speed}。");

namespace OOP
{
    public class Car
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Speed { get; set; }
        public void Accelerate(int speed)
        {
            Speed += speed;
            if (Speed > 200)
            {
                Speed = 200;
            }
        }
    }

    public class Honda : Car
    {
        public virtual string door()
        {
            return "";
        }
    }

    public class Nissan : Car
    {

    }

    public class SmallHonda : Honda
    {
        public override string door()
        {
            return "";
        }
    }
}







//封裝(encapsulation)
//繼承(inheritance)
//多型(Polymorphism)

