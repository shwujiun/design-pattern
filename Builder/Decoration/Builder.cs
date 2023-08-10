using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Decoration
{
    public abstract class Builder
    {
        public abstract Builder appendCeiling(IMatter matter); // 吊頂
        public abstract Builder appendCoat(IMatter matter);    // 塗料
        public abstract Builder appendFloor(IMatter matter);   // 地板
        public abstract Builder appendTile(IMatter matter);    // 地磚
        public abstract string getDetail();                 // 明細 
    }


}
