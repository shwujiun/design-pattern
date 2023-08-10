
using System;

//抽象(abstract)
public class Car
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Speed { get; set; }
    public void Accelerate()
    {

    }
}

Car car = new Car();
car.Brand = "Honda";
car.Color = "Blue";
car.Speed = 60;

Console.WriteLine($"建立一台汽車，廠牌：{car.Brand}，顏色：{car.Color}，目前速度：{car.Speed}。");




//封裝(encapsulation)
//繼承(inheritance)
//多型(Polymorphism)

