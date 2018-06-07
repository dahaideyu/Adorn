using Adorn.Domain.Entity.SystemSecurity;
using Microsoft.EntityFrameworkCore;


namespace Adorn.Mapping.SystemSecurity
{
    public class DbBackupMap : EntityTypeConfiguration<DbBackupEntity>
    {
        //public DbBackupMap()
        //{
        //    this.ToTable("Sys_DbBackup");
        //    this.HasKey(t => t.F_Id);
        //}
        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbBackupEntity>().ToTable("Sys_DbBackup").HasKey(_ => _.F_Id);
        }
    }
}
