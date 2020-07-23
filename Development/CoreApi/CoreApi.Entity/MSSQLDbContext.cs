/*********************************************************************************** 
 *   Filename :MSSQLDbContext  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
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
