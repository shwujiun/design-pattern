using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Decoration
{
    public class DecorationPackageController
    {

        public string GetMatterList(decimal area, int level)
        {
            List<IMatter> list = new List<IMatter>();
            decimal price = 0;

            if (level == 1)
            {
                LeveTwoCeiling leveTwoCeiling = new LeveTwoCeiling();
                DulexCost dulexCost = new DulexCost();
                ShengXiangFloor shengXiangFloor = new ShengXiangFloor();
                list.Add(leveTwoCeiling);
                list.Add(dulexCost);
                list.Add(shengXiangFloor);



                price += decimal.Multiply(decimal.Multiply(area, 0.2m), leveTwoCeiling.price());
                price += decimal.Multiply(decimal.Multiply(area, 1.4m), dulexCost.price());
                price += decimal.Multiply(area, shengXiangFloor.price());
            }
            else if (level == 2)
            {

            }
            else if (level == 3)
            {
            }

            StringBuilder detail = new StringBuilder(
                "\r\n-------------------------------------------------------\r\n" +
                "裝修清單" + "\r\n" +
                "套餐等級：" + level + "\r\n" +
                "套餐價格：" + price + " 元\r\n" +
                "房屋面積：" + area + " 平米\r\n" +
                "材料清單：\r\n");


            foreach (var matter in list)
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
