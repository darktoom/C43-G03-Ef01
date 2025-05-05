using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.models
{



    #region

    //model : poco class [plain old clr object]-domain entity
    //  internal class Employee
    // {
    //    public int Id { get; set; } // pk with identity constraint [1,1]
    //    public string? EmpName { get; set; }
    //    //nullable reference type
    //    //string? is mapped to nvarchar(max) allow null
    //    public decimal Salary { get; set; }
    //    /*value type 
    //     * not allow null
    //     * decimal is mapped  to decimal (18,2) not allow null
    //    */
    //    public int Age { get; set; }
    //    /*
    //     value type
    //    int is mapped to int not null

    //    */

    //   }
    #endregion
    #region data anntation

    internal class Employee
    {

       
        public int EmpId { get; set; } // pk with identity constraint [1,1]
        [Required]
        
    
        [MinLength(3,ErrorMessage ="name of employee more than 3 char")]
        
   
        public  string EmpName { get; set; }
        //nullable reference type
        //string? is mapped to varchar(50)  not allow null
        [Column("EmpSalary")]
        public decimal Salary { get; set; }
        /*value type 
         * not allow null
         * decimal is mapped  to decimal (18,2) not allow null

         */
        [Column("EmpAge")]
        // [Range(20,40)]
        //   [AllowedValues]
        //[DeniedValues(21,22)]
        public int Age { get; set; }
        /*
         value type
        int is mapped to int not null

        */
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber  { get; set; }

        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAdress {  get; set; }
        [NotMapped]
        public string property { get; set; }

    }
    #endregion
}
