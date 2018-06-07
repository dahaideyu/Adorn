﻿using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;


namespace Adorn.Mapping.SystemManage
{
    public class UserLogOnMap : EntityTypeConfiguration<UserLogOnEntity>
    {
        //public UserLogOnMap()
        //{
        //    this.ToTable("Sys_UserLogOn");
        //    this.HasKey(t => t.F_Id);
        //}

        public override void Map(ModelBuilder builder)
        {
            builder.Entity<UserLogOnEntity>().ToTable("Sys_UserLogOn").HasKey(_ => _.F_Id);
        }

    }
}
