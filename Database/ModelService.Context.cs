﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPC_SUPPORT_WIP.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UMC_MESDB_TESTEntities : DbContext
    {
        public UMC_MESDB_TESTEntities()
            : base("name=UMC_MESDB_TESTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<WORK_ORDER_ITEMS> WORK_ORDER_ITEMS { get; set; }
        public DbSet<SCANNING_LOGS> SCANNING_LOGS { get; set; }
    }
}