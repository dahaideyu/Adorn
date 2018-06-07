﻿using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;

namespace Adorn.Mapping.SystemManage
{
    public class ItemsDetailMap : EntityTypeConfiguration<ItemsDetailEntity>
    {
        //public ItemsDetailMap()
        //{
        //    this.ToTable("Sys_ItemsDetail");
        //    this.HasKey(t => t.F_Id);
        //}
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemsDetailEntity>().ToTable("Sys_ItemsDetail").HasKey(_ => _.F_Id);
        }
    }
}
