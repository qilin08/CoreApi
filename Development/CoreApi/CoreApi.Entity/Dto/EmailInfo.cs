using System.Collections.Generic;

namespace CoreApi.Entity.Dto
{
    /// <summary>
    /// 邮件基本信息
    /// </summary>
    public class EmailInfo
    {
        /// <summary>
        /// 发件人
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public List<string> To { get;set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public List<string> CC { get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 邮件正文
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public List<string> Attachments { get; set; }
    }
}
