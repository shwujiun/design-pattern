using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    internal class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder= builder;
        }

        public Product makeProduct(string productName, string companyName, string part1, string part2, string part3)
        {
            builder.buildProductName(productName);
            builder.buildCompanyName(companyName);
            builder.buildPart1(part1);
            builder.buildPart2(part2);
            builder.buildPart3(part3);
            return builder.build();


        }
    }
}
