/*********************************************************************************** 
 *   Filename :Sys_ConfigValues  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using System.ComponentModel.DataAnnotations;

namespace CoreApi.Entity.Models
{
    /// <summary>
    /// 系统选项配置
    /// </summary>
    public class Sys_ConfigValues
    {
        [Key]
        public int IID { get; set; }
        public int Key { get; set; }
        public string Property0 { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string Property4 { get; set; }
        public string Property5 { get; set; }
        public string Property6 { get; set; }
        public string Property7 { get; set; }
        public string Property8 { get; set; }
        public string Property9 { get; set; }
        public string Property10 { get; set; }
    }
}
