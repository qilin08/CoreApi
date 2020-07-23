/*********************************************************************************** 
 *   Filename :IEmail  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using CoreApi.Entity.Dto;

namespace CoreApi.IService.Email
{
    /// <summary>
    /// 邮件相关接口
    /// </summary>
    public interface IEmail
    {
        /// <summary>
        /// 邮箱自动登陆
        /// </summary>
        /// <returns></returns>
        Result EmailAutoLogin();

        /// <summary>
        /// 设置邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        Result SetEmailInfo(EmailAccountInfo info);

        /// <summary>
        /// 邮件发送
        /// </summary>
        /// <returns></returns>
        Result SendMail(EmailInfo info);

        /// <summary>
        /// 获取邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        Result GetEmailInfo();
    }
}
