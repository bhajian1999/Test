﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Check_Print.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CHECK_PRINTEntities : DbContext
    {
        public CHECK_PRINTEntities()
            : base("name=CHECK_PRINTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Check> Check { get; set; }
        public virtual DbSet<CheckDoc> CheckDoc { get; set; }
        public virtual DbSet<DastehCheck> DastehCheck { get; set; }
        public virtual DbSet<PrintFormat> PrintFormat { get; set; }
        public virtual DbSet<Reciver> Reciver { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<PrintFormatDimention> PrintFormatDimention { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
