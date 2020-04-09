using System;
using System.Collections.Generic;
using System.Text;
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

        public DbSet<Disease> Disease { get; set; }

        #region Sys

        public DbSet<Sys_ConfigValues> Sys_ConfigValues { get; set; }

        #endregion


    }
}
