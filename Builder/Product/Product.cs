using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    internal class Product
    {
        private  string ProductName;
        private  string CompanyName;
        private  string part1;
        private  string part2;
        private  string part3;

        public Product(string productName, string companyName, string part1, string part2, string part3)
        {
            this.ProductName = productName;
            this.CompanyName = companyName;
            this.part1 = part1;
            this.part2 = part2;
            this.part3 = part3;
        }
        public override string ToString()
        {
            return this.ProductName;
        }

    }
}
