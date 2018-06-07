using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Adorn.Domain.Entity.SystemManage;

namespace Adorn.Mapping.SystemManage
{
    public class NewsInfoMap:EntityTypeConfiguration<NewsInfoEntity>
    {
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsInfoEntity>().ToTable("Sys_NewsInfo").HasKey(_ => _.F_Id);
        }
    }
}
