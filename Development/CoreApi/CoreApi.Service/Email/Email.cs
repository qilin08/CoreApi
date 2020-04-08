using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Dto;
using CoreApi.IService.Email;

namespace CoreApi.Service.Email
{
    /// <summary>
    /// 邮件相关服务
    /// </summary>
    public class Email : IEmail
    {
        /// <summary>
        /// 邮箱自动登陆
        /// </summary>
        /// <returns></returns>
        public Result EmailAutoLogin()
        {
            var result = new Result();



            result.Message = result.IsSuccess ? "邮箱自动登录成功！" : "邮箱自动登录失败！";
            return result;
        }

        /// <summary>
        /// 设置邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        public Result SetEmailInfo()
        {
            var result = new Result();



            result.Message = result.IsSuccess ? "邮箱登录相关信息设置成功！" : "邮箱登录相关信息设置失败！";
            return result;
        }
    }
}
