using Core.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
