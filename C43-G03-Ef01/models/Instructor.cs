using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.models
{
    internal class Instructor
    {


        public int Id { get; set; }

        public string Name { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public int HourRate { get; set; }
        public int Dept_ID { get; set; }

    }
}
