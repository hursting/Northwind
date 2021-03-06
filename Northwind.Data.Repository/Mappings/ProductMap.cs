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
    
    public partial class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {                        
              this.HasKey(t => t.ProductID);        
              this.ToTable("Products");
              this.Property(t => t.ProductID).HasColumnName("ProductID");
              this.Property(t => t.ProductName).HasColumnName("ProductName").IsRequired().HasMaxLength(40);
              this.Property(t => t.SupplierID).HasColumnName("SupplierID");
              this.Property(t => t.CategoryID).HasColumnName("CategoryID");
              this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit").HasMaxLength(20);
              this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
              this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
              this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
              this.Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
              this.Property(t => t.Discontinued).HasColumnName("Discontinued");
              this.HasOptional(t => t.Category).WithMany(t => t.Products).HasForeignKey(d => d.CategoryID);
              this.HasOptional(t => t.Supplier).WithMany(t => t.Products).HasForeignKey(d => d.SupplierID);
         }
    }
}
