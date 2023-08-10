using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    internal class ProductBuilder2: Builder
    {
        private string ProductName;
        private string CompanyName;
        private string part1;
        private string part2;
        private string part3;

        public void buildProductName(string input)
        {
            this.ProductName = input;
        }
        public void buildCompanyName(string input)
        {
            this.CompanyName= input;
        }

        public void buildPart1(string input)
        {
            this.part1 = input;
        }

        public void buildPart2(string input)
        {
            this.part2 = input;
        }

        public void buildPart3(string input)
        {
            this.part3 = input;
        }

        public Product build()
        {
            return new Product(ProductName, CompanyName, part1, part2, part3);
        }
    }
}
