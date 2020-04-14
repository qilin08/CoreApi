using Core.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;
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
