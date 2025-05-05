using C43_G03_Ef01.ModelConfig;
using C43_G03_Ef01.models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.DbContexts
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext():base()
        {
            


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data source=.;Initial catalog= CompanyDb ; intergated security = true");
            optionsBuilder.UseSqlServer("server=.;database= CompanyDb ; trusted_connection = true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //     modelBuilder.Entity<Employee>().HasKey(e=>e.EmpId);
            //      modelBuilder.Entity<Employee>()
            //.Property<string>("name");// will define "name"as shadow property

            //      modelBuilder.Entity<Employee>()
            //          .Property(e=>e.EmpName)
            //          .HasColumnName("employee name")
            //          .HasColumnType("varchar")
            //          .HasMaxLength(50)
            //          .IsRequired(false)
            //          ;

            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfig());

            //modelBuilder.ApplyConfiguration(new DepartmentConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Department>(d =>
            //{

            //    d.ToTable("departments", "sales");
            //    d.HasKey(d => d.DeptId);
            //    // d.Property(d=>d.DeptId).UseIdentityColumn(10,10);
            //    d.Property(d => d.DeptId).ValueGeneratedNever(); //disable idenity constraint

            //    d.Property(d => d.DeptId).HasDefaultValueSql("NewGuid");
            //    d.Property(d => d.DeptName).HasColumnName("Department Name").HasColumnType("varchar")
            //    .HasMaxLength(20)
            //    .HasDefaultValue("hr");
            //    d.Property(d => d.DateCreation).HasAnnotation("DataType", "date")
            //    .HasDefaultValueSql("GetDate()");//.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));
            //    d.Ignore(d => d.Serial);

            //}
            //);
        }



      //  public DbSet<Employee>? Employees { get; set; }
       //public DbSet<Department>? department { get; set; }


    }
}
