
using System;

//��H(abstract)
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

Console.WriteLine($"�إߤ@�x�T���A�t�P�G{car.Brand}�A�C��G{car.Color}�A�ثe�t�סG{car.Speed}�C");




//�ʸ�(encapsulation)
//�~��(inheritance)
//�h��(Polymorphism)

