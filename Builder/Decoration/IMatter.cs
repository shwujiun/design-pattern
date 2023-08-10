using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Decoration
{
    //將一個複雜對象的創建與他的表示分離，使得同樣的構建過程可以創建不同的表示
    public abstract class IMatter
    {
        abstract public string scene();
        abstract public string brand();
        abstract public string model();
        abstract public decimal price();
        abstract public string desc();
    }

    //吊頂
    class LevelOneCeiling : IMatter
    {
        public override string brand()
        {
            return "装修公司自带";
        }

        public override string desc()
        {
            return "造型只做低一级，只有一个层次的吊顶，一般离顶120-150mm";
        }

        public override string model()
        {
            return "一级顶";
        }

        public override decimal price()
        {
            return 260;
        }

        public override string scene()
        {
            return "吊顶";
        }
    }

    class LeveTwoCeiling : IMatter
    {
        public override string brand()
        {
            return "装修公司自带";
        }

        public override string desc()
        {
            return "两个层次的吊顶，二级吊顶高度一般就往下吊20cm，要是层高很高，也可增加每级的厚度";
        }

        public override string model()
        {
            return "二级顶";
        }

        public override decimal price()
        {
            return 850;
        }

        public override string scene()
        {
            return "吊顶";
        }
    }

    //塗料
    class DulexCost : IMatter
    {
        public override string brand()
        {
            return "多乐士(Dulux)";
        }

        public override string desc()
        {
            return "多乐士是阿克苏诺贝尔旗下的著名建筑装饰油漆品牌，产品畅销于全球100个国家，每年全球有5000万户家庭使用多乐士油漆。";
        }

        public override string model()
        {
            return "第二代";
        }

        public override decimal price()
        {
            return 719;
        }

        public override string scene()
        {
            return "涂料";
        }
    }

    class LibanCost : IMatter
    {
        public override string brand()
        {
            return "立邦";
        }

        public override string desc()
        {
            return "立邦始终以开发绿色产品、注重高科技、高品质为目标，以技术力量不断推进科研和开发，满足消费者需求。";
        }

        public override string model()
        {
            return "默认级别";
        }

        public override decimal price()
        {
            return 650;
        }

        public override string scene()
        {
            return "涂料";
        }
    }

    //地板
    class DerFloor : IMatter
    {
        public override string brand()
        {
            return "德尔(Der)";
        }

        public override string desc()
        {
            return "DER德尔集团是全球领先的专业木地板制造商，北京2008年奥运会家装和公装地板供应商";
        }

        public override string model()
        {
            return "A+";
        }

        public override decimal price()
        {
            return 119;
        }

        public override string scene()
        {
            return "地板";
        }
    }

    class ShengXiangFloor : IMatter
    {
        public override string brand()
        {
            return "圣象";
        }

        public override string desc()
        {
            return "圣象地板是中国地板行业著名品牌。圣象地板拥有中国驰名商标、中国名牌、国家免检、中国环境标志认证等多项荣誉。";
        }

        public override string model()
        {
            return "一級";
        }

        public override decimal price()
        {
            return 318;
        }

        public override string scene()
        {
            return "地板";
        }
    }
    //地砖(tile)
    class DongPengTile : IMatter
    {
        public override string brand()
        {
            return "东鹏瓷砖";
        }

        public override string desc()
        {
            return "圣象地板是中国地板行业著名品牌。圣象地板拥有中国驰名商标、中国名牌、国家免检、中国环境标志认证等多项荣誉。";
        }

        public override string model()
        {
            return "10001";
        }

        public override decimal price()
        {
            return 102;
        }

        public override string scene()
        {
            return "地砖";
        }
    }

    class MarcoPoloTile : IMatter
    {
        public override string brand()
        {
            return "马可波罗(MARCO POLO)";
        }

        public override string desc()
        {
            return "“马可波罗”品牌诞生于1996年，作为国内最早品牌化的建陶品牌，以“文化陶瓷”占领市场，享有“仿古砖至尊”的美誉。";
        }

        public override string model()
        {
            return "缺省";
        }

        public override decimal price()
        {
            return 140;
        }

        public override string scene()
        {
            return "地砖";
        }
    }
}
