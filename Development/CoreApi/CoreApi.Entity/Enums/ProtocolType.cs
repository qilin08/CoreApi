/*********************************************************************************** 
 *   Filename :ProtocolType  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/

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
