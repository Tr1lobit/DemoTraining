﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Afonichev.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoDb_AfonichevEntities : DbContext
    {
        public DemoDb_AfonichevEntities()
            : base("name=DemoDb_AfonichevEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityJury> ActivityJury { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Direction> Direction { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}