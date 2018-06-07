using Adorn.Domain.Entity.SystemManage;
using Microsoft.EntityFrameworkCore;


namespace Adorn.Mapping.SystemManage
{
    public class ModuleButtonMap : EntityTypeConfiguration<ModuleButtonEntity>
    {
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModuleButtonEntity>().ToTable("Sys_ModuleButton").HasKey(_ => _.F_Id);
        }
    }
}
