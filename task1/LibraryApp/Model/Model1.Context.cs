﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp_task27_.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryDbEntities2 : DbContext
    {
        public LibraryDbEntities2()
            : base("name=LibraryDbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Login_Admin> Login_Admin { get; set; }
        public virtual DbSet<Login_Users> Login_Users { get; set; }
        public virtual DbSet<SaleBook> SaleBooks { get; set; }
        public virtual DbSet<SalestoBook> SalestoBooks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Typess> Typesses { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
