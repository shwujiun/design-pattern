using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Resume : ICloneable
    {
        private string sex;
        private string age;
        private string timeArea, company, name;

        public Resume(string name)
        {
            this.name = name;
        }

        public void setPersonInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }
        
        public void setWork(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public void display()
        {
            Console.WriteLine("{0} {1} {2}", this.name, this.sex, this.age);
            Console.WriteLine("工作經歷 {0} {1} ", this.timeArea, this.company);
        }

    }
}
