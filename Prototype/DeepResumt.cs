using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    internal class WorkExp : ICloneable
    {
        public string timeArea { get; set; }
        public string company { get; set; }

        public object clone() => MemberwiseClone();

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
    internal class DeepResume : ICloneable
    {
        private string sex = "";
        private string age = "";
        private string name = "";

        private readonly WorkExp work;

        private DeepResume(WorkExp work)
        {
            this.work=(WorkExp)work.clone();
        }


        public DeepResume(string name)
        {
            this.name = name;
            work = new WorkExp();
        }


        public void setPersonInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("{0} {1} {2}", this.name, this.sex, this.age);
            Console.WriteLine("工作經歷 {0} {1} ", this.work.timeArea, this.work.company);
        }

        public object Clone()
        {
            DeepResume dr = new DeepResume(this.work);
            dr.name = this.name;
            dr.age = this.age;
            dr.sex = this.sex;
            return dr;


        }

        public void SetWorkExperience(string comapny, string timePeriod)
        {
            this.work.company = comapny;
            this.work.timeArea =  timePeriod;
        }

    }

}
