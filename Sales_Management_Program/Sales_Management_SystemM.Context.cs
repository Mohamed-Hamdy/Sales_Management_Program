//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sales_Management_Program
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sales_Management_SystemEntities1 : DbContext
    {
        public Sales_Management_SystemEntities1()
            : base("name=Sales_Management_SystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TB_CAT> TB_CAT { get; set; }
        public virtual DbSet<TB_Suppliers> TB_Suppliers { get; set; }
        public virtual DbSet<TB_Purchases> TB_Purchases { get; set; }
        public virtual DbSet<TB_Customers> TB_Customers { get; set; }
        public virtual DbSet<TB_Sales> TB_Sales { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
    }
}
