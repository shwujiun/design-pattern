// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Factory.CreateProduct("A");


class Factory
{


    public static Product CreateProduct(string type)
    {
        Product p = null;
        switch (type)
        {
            case "A":
                p = new ProductA();
                break;
            case "B":
                p = new ProductB();
                break;
            default:
                throw new Exception("Error");
        }
        return p.CreateObj();
    }


}

abstract class Product
{
    abstract public Product CreateObj();
}

class ProductA : Product
{
    public override Product CreateObj()
    {
        Console.WriteLine("ProductA");
        return new ProductA();
    }
}
class ProductB : Product
{
    public override Product CreateObj()
    {
        Console.WriteLine("ProductB");
        return new ProductB();
    }
}
