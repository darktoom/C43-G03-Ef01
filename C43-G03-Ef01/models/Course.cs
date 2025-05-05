using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; } 
        public int duration { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Top_Id {  get; set; } 





    }
}
