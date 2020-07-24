/*********************************************************************************** 
 *   Filename :DbModel  
 *   Date:2020/07/24 10:27:19 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 主流数据库类型
 * 
 *   ChangeLog: 
 *   2020/07/24 10:27:19: Created! 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.Entity.Enums
{
    public enum DbModel
    {
        MySql=0,
        SQLServer = 1,
        Oracle = 2,
        PostgreSQL=3,
        SQLLite =4,
    }
}
