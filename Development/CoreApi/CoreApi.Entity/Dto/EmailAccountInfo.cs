using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.Entity.Dto
{
    /// <summary>
    /// 邮箱账号信息配置
    /// </summary>
    public class EmailAccountInfo
    {
        public string EmailAccount { get; set; }

        public string PassWord { get; set; }

        public string EmailType { get; set; }

    }
}
