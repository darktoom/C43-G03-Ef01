using C43_G03_Ef01.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace C43_G03_Ef01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            //var Employee = dbContext.Employees.Where(e => e.EmpName == "hatem").FirstOrDefault();


         //   dbContext.Database.Migrate();
          

        }
       
	 


    }
}
