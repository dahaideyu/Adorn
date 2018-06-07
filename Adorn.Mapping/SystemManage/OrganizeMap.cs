using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;


namespace Adorn.Mapping.SystemManage
{
    public class OrganizeMap : EntityTypeConfiguration<OrganizeEntity>
    {
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizeEntity>().ToTable("Sys_Organize").HasKey(_ => _.F_Id);
        }
    }
}
