using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Dto;
using CoreApi.IService.Email;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Linq;
using System.Net.Mime;
using CoreApi.Entity;
using CoreApi.Entity.Category;
using CoreApi.Entity.Dto;
using CoreApi.Entity.Models;
using Newtonsoft.Json;

namespace CoreApi.Service.Email
{
    /// <summary>
    /// 邮件相关服务
    /// </summary>
    public class Email : IEmail
    {

        private readonly MYSQLDbContext _context;

        public Email(MYSQLDbContext context)
        {
            _context = context;
        }

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
        /// 邮件发送
        /// </summary>
        /// <returns></returns>
        public Result SendMail(EmailInfo info)
        {
            var result = new Result();
            var emailAccountInfo =
                _context.Sys_ConfigValues.FirstOrDefault(x => x.Key == (int) SystemCfgType.EmailAccount);

            if (emailAccountInfo==null)
            {
                result.IsSuccess = false;
                result.Message = "请配置邮箱信息!";
            }

            try
            {

            }
            catch (Exception e)
            {
                return new Result(false, "邮件发送异常，请检查邮箱配置，具体异常原因请查看日志！");
            }

            result.Message = result.IsSuccess ? "邮件发送成功！" : "邮件发送失败！";
            return result;
        }

        /// <summary>
        /// 获取邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        public Result GetEmailInfo()
        {
            var sysValue =  _context.Sys_ConfigValues.FirstOrDefault(x => x.Key == (int)SystemCfgType.EmailAccount);
            if (sysValue != null&&!string.IsNullOrEmpty(sysValue.Property0))
            {
                var info = JsonConvert.DeserializeObject<EmailAccountInfo>(sysValue.Property0);
                return new Result(true,"",info);
            }

            return new Result(false, "获取邮箱相关信息失败，信息未配置！");
        }

        /// <summary>
        /// 设置邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        public Result SetEmailInfo(EmailAccountInfo info)
        {
            var result = new Result();
            if (info == null)
            {
                result.IsSuccess = false;
                result.Message = "邮箱登录相关信息为空，请检查后重试！";
                return result;
            }

            var property0 = JsonConvert.SerializeObject(info);
            var sysValue = _context.Sys_ConfigValues.FirstOrDefault(x => x.Key == (int)SystemCfgType.EmailAccount);
            if (sysValue == null)
            {
                _context.Sys_ConfigValues.Add(new Sys_ConfigValues()
                {
                    Key = (int)SystemCfgType.EmailAccount,
                    Property0 = property0
                });
            }
            else
            {
                sysValue.Property0 = property0;
            }

            result.IsSuccess = _context.SaveChanges() > 0;
            result.Message = result.IsSuccess ? "邮箱登录相关信息设置/更新成功！" : "邮箱登录相关信息设置/更新失败！";
            return result;
        }
    }
}
