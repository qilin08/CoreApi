using System;
using System.Collections.Generic;
using System.Text;
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

    }
}
