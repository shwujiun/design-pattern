using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Decoration
{
    public class Director
    {
        public Builder LevelOne(decimal area)
        {
            return new PackageBuilder(1, area)
                .appendCeiling(new LeveTwoCeiling())    // 吊頂，二級頂
                .appendCoat(new DulexCost())             // 塗料，多樂士
                .appendFloor(new ShengXiangFloor());     // 地板，聖像
        }
        public Builder LevelTwo(decimal area)
        {
            return new PackageBuilder(2, area)
                .appendCeiling(new LeveTwoCeiling())   // 吊頂，二級頂
                .appendCoat(new LibanCost())           // 塗料，立邦
                .appendTile(new MarcoPoloTile());       // 地磚，馬可波羅
        }
        public Builder levelThree(decimal area)
        {
            return new PackageBuilder(3, area)
                .appendCeiling(new LevelOneCeiling())   // 吊頂，二級頂
                .appendCoat(new LibanCost())           // 塗料，立邦
                .appendTile(new DongPengTile());        // 地磚，東鵬
        }
    }
}
