using C43_G03_Ef01.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef01.ModelConfig
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>

    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);
         
    builder.Property<string>("name");// will define "name"as shadow property

            builder.Property(e => e.EmpName)
                .HasColumnName("employee name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false)
                ;

        }
    }


}
