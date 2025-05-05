using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.models
{
    [PrimaryKey(nameof(Stud_ID),nameof(Course_Id))]
    internal class Stud_Course
    {


        public  int Stud_ID { get; set;}
        public int Course_Id { get; set;}
        public string? grade { get; set;}


    }
}
