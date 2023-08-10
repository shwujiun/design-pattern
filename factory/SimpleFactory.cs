using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    //一個用於創建對象的接口，讓子類決定實例化哪一個類。
    //Factory 使的一個類的實例延遲到子類

    class SimpleFactory
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