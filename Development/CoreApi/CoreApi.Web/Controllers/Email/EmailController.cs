using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Entity.Dto;
using CoreApi.IService.Email;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Web.Controllers.Email
{
    /// <summary>
    /// 邮件相关服务接口
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmail _email;

        public EmailController(IEmail email)
        {
            _email = email ?? throw new ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// 邮箱自动登陆
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public Result EmailAutoLogin()
        {
            return _email.EmailAutoLogin();
        }

        /// <summary>
        /// 设置邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public Result SetEmailInfo(EmailAccountInfo info)
        {
            return _email.SetEmailInfo(info);
        }

        /// <summary>
        /// 获取邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public Result GetEmailInfo()
        {
            return _email.GetEmailInfo();
        }

        /// <summary>
        /// 邮件发送
        /// </summary>
        /// <returns></returns>
        [HttpPost("[action]")]
        public Result SendMail(EmailInfo info)
        {
            return _email.SendMail(info);
        }
    }
}
