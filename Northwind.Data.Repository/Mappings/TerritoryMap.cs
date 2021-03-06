//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.Data.Repository.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    using Northwind.Core;
    
    public partial class TerritoryMap : EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {                        
              this.HasKey(t => t.TerritoryID);        
              this.ToTable("Territories");
              this.Property(t => t.TerritoryID).HasColumnName("TerritoryID").IsRequired().HasMaxLength(20);
              this.Property(t => t.TerritoryDescription).HasColumnName("TerritoryDescription").IsRequired().IsFixedLength().HasMaxLength(50);
              this.Property(t => t.RegionID).HasColumnName("RegionID");
              this.HasRequired(t => t.Region).WithMany(t => t.Territories).HasForeignKey(d => d.RegionID);
         }
    }
}

