/*********************************************************************************** 
 *   Filename :Disease  
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
    public class Disease
    {
        [Key]
        public string DID { get; set; }

        [Display(Name = "疾病名称")]
        public string DName { get; set; }

        [Display(Name = "疾病类别")]
        public string DType { get; set; }

        [Display(Name = "疾病等级")]
        public string DGrade { get; set; }

        [Display(Name = "疾病信息")]
        public string DInfo { get; set; }
    }
}
