using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
