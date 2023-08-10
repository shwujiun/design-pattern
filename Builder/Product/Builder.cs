using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    internal interface Builder
    {
        void buildProductName(string input);
        void buildCompanyName(string input);
        void buildPart1(string input);
        void buildPart2(string input);
        void buildPart3(string input);

        Product build();

    }
}
