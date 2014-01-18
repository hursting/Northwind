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
    
    public partial class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {                        
              this.HasKey(t => t.RegionID);        
              this.ToTable("Region");
              this.Property(t => t.RegionID).HasColumnName("RegionID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.RegionDescription).HasColumnName("RegionDescription").IsRequired().IsFixedLength().HasMaxLength(50);
         }
    }
}
