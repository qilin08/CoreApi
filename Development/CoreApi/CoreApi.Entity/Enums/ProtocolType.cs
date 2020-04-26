using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.Entity.Enums
{
    /// <summary>
    /// 邮件相关协议
    /// </summary>
    public enum ProtocolType
    {
        /// <summary>
        /// Simple Mail Transfer Protocal
        /// </summary>
        SMTP = 1,

        /// <summary>
        /// Post Office Protocal 3
        /// </summary>
        POP3 = 2,

        /// <summary>
        /// Internet消息访问协议
        /// </summary>
        IMAP = 3,
    }
}
