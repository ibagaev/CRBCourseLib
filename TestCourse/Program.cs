using CRBCourseLib;
using CRBCourseLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICRBCourse crb = new CRBCourse();


            var vals = new List<ValuteCode>
            {
                ValuteCode.USD,
                ValuteCode.EUR,
                ValuteCode.TRY
            };

            crb.GetDeilyCourseList(vals, DateTime.Parse("18/10/2013")).ForEach(val => { Console.WriteLine(val); });
  

            Console.ReadLine();
        }
    }
}
