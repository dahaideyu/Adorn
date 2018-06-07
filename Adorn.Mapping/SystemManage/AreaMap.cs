using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;

namespace Adorn.Mapping.SystemManage
{
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaEntity>().ToTable("Sys_Area").HasKey(_ => _.F_Id);
        }
    }
}
