﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThunderDuckGroup.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ThunderDuckEntities : DbContext
    {
        public ThunderDuckEntities()
            : base("name=ThunderDuckEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Td_BrandMaker_AreaType> Td_BrandMaker_AreaType { get; set; }
        public virtual DbSet<Td_BrandMaker_Contact> Td_BrandMaker_Contact { get; set; }
        public virtual DbSet<Td_BrandMaker_Events> Td_BrandMaker_Events { get; set; }
        public virtual DbSet<Td_BrandMaker_Images> Td_BrandMaker_Images { get; set; }
        public virtual DbSet<Td_BrandMaker_Members> Td_BrandMaker_Members { get; set; }
        public virtual DbSet<Td_BrandMaker_News> Td_BrandMaker_News { get; set; }
        public virtual DbSet<Td_BrandMaker_Slider> Td_BrandMaker_Slider { get; set; }
        public virtual DbSet<Td_BrandMaker_Story> Td_BrandMaker_Story { get; set; }
        public virtual DbSet<Td_BrandMaker_ThunderDuckType> Td_BrandMaker_ThunderDuckType { get; set; }
        public virtual DbSet<Td_BrandMaker_Tours> Td_BrandMaker_Tours { get; set; }
        public virtual DbSet<Td_Construction_Construction> Td_Construction_Construction { get; set; }
        public virtual DbSet<Td_Construction_Contact> Td_Construction_Contact { get; set; }
        public virtual DbSet<Td_Construction_Member> Td_Construction_Member { get; set; }
        public virtual DbSet<Td_Construction_New> Td_Construction_New { get; set; }
        public virtual DbSet<Td_Construction_Slider> Td_Construction_Slider { get; set; }
        public virtual DbSet<Td_Construction_Images> Td_Construction_Images { get; set; }
        public virtual DbSet<Td_Constrution_Story> Td_Constrution_Story { get; set; }
    }
}
