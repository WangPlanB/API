﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetStoreEntities1 : DbContext
    {
        public PetStoreEntities1()
            : base("name=PetStoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<OrderMassage> OrderMassage { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetHead> PetHead { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
