/*********************************************************************************** 
 *   Filename :MYSQLDbContext  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using CoreApi.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Entity
{
    /// <summary>
    /// MySql数据库连接
    /// </summary>
    public class MYSQLDbContext : DbContext
    {
        public MYSQLDbContext(DbContextOptions<MYSQLDbContext> options) : base(options)
        {

        }



        #region DbSet Entity映射到数据库表

        public DbSet<Disease> Disease { get; set; }
        public DbSet<Sys_ConfigValues> Sys_ConfigValues { get; set; }

        #endregion


    }
}
