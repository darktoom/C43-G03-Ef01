using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.models
{

    [PrimaryKey(nameof(Idinst_ID),nameof(Course_ID))]
    internal class Course_Inst
    {


        public int Idinst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get;set; }

    }
}
