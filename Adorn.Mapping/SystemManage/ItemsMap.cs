﻿using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;


namespace Adorn.Mapping.SystemManage
{
    public class ItemsMap : EntityTypeConfiguration<ItemsEntity>
    {
        //public ItemsMap()
        //{
        //    this.ToTable("Sys_Items");
        //    this.HasKey(t => t.F_Id);
        //}
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemsEntity>().ToTable("Sys_Items").HasKey(_ => _.F_Id);
        }
    }
}
