using Microsoft.EntityFrameworkCore;

namespace CoreApi.Entity
{
    /// <summary>
    /// SQLServer数据库连接
    /// </summary>
    public class MSSQLDbContext : DbContext
    {
        public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options) : base(options)
        {

        }

        #region DbSet Entity映射到数据库表

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
