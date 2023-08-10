using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Decoration
{
    public class PackageBuilder : Builder
    {
        private int level;
        private decimal area;
        private decimal price = 0;
        private List<IMatter> matters = new List<IMatter>();

        private PackageBuilder() { }
        public PackageBuilder(int level, decimal area)
        {
            this.level = level;
            this.area = area;
        }

        public override Builder appendCeiling(IMatter matter)
        {
            matters.Add(matter);
            return this;
        }

        public override Builder appendCoat(IMatter matter)
        {
            matters.Add(matter);
            return this;
        }

        public override Builder appendFloor(IMatter matter)
        {
            matters.Add(matter);
            return this;
        }

        public override Builder appendTile(IMatter matter)
        {
            matters.Add(matter);
            return this;
        }

        public override string getDetail()
        {
            StringBuilder detail = new StringBuilder(
                "\r\n-------------------------------------------------------\r\n" +
                "裝修清單" + "\r\n" +
                "套餐等級：" + level + "\r\n" +
                "套餐價格：" + price + " 元\r\n" +
                "房屋面積：" + area + " 平米\r\n" +
                "材料清單：\r\n");


            foreach (var matter in matters)
            {

                detail.Append(matter.scene())
                    .Append("：")
                    .Append(matter.brand())
                    .Append("、")
                    .Append(matter.model())
                    .Append("、平米價格：")
                    .Append(matter.price())
                    .Append(" 元。\n");
            }
            return detail.ToString();
        }
    }
}
