using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //從一個對象在創建另外一個可訂製的對象，而且不需要知道創建的細節
    //在初始化的信息不發生變化的情況下，clone是最好的辦法，隱藏了創建的細節也大大提升性能

    abstract class Prototype
    {
        public string Id { get; }

        public Prototype(string id)
        {
            this.Id=id;
        }
        public abstract Prototype Clone();

    }
}
