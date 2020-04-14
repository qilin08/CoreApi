using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApi.Entity.Dto
{
    /// <summary>
    /// 邮箱账号信息配置
    /// </summary>
    public class EmailAccountInfo
    {
        /// <summary>
        /// Email地址
        /// </summary>
        public string EmailAccount { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 邮箱类型
        /// </summary>
        public string EmailType { get; set; }

        /// <summary>
        /// 收件服务器
        /// </summary>
        public string PickUpServer { get; set; }
        
        /// <summary>
        /// 发件服务器
        /// </summary>
        public string SendingServer { get; set; }

        /// <summary>
        /// 是否使用SSL
        /// </summary>
        public bool IsSSL { get; set; }

    }
}
