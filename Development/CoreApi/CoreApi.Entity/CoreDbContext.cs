using System;
using Microsoft.EntityFrameworkCore;

namespace Core.Entity
{
    public class CoreDbContext: DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        #region DbSet Entity映射到数据库表

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
