using System;
using System.Collections.Generic;
using CoreApi.IService.Email;
using System.Net;
using System.Net.Mail;
using System.Linq;
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

            var emailInfo = GetEmailAccountInfo();

            if (emailInfo == null)
            {
                result.IsSuccess = false;
                result.Message = "请配置邮箱信息!";
            }

            //创建邮件
            var message = new MailMessage
            {
                Priority = MailPriority.Normal,
                From = new MailAddress(info.From),
                Subject = info.Subject,
                Body = info.Body,

                #region 邮件相关配置

                //邮件的优先级，分为 Low, Normal, High，通常用 Normal即可
                //对方回复邮件时默认的接收地址(不设置也是可以的哟)
                //message.ReplyTo = new MailAddress(info.From);
                //如果你的邮件标题包含中文，这里一定要指定，否则对方收到的极有可能是乱码。
                //message.SubjectEncoding = Encoding.GetEncoding(936);
                //邮件正文是否是HTML格式
                //message.IsBodyHtml = false;
                //获取或设置此电子邮件的发送通知。会有邮件通知到发送邮件箱；
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess,

                #region 上传指定附件做邮件签名

                ////先将要处理的图片作为附件添加--作为邮件签名
                //Attachment attachment = new Attachment(@"C:\Users\SQL\Desktop\邮件签名.png");
                //message.Attachments.Add(attachment);
                ////相当与邮件内容定义成html
                //message.IsBodyHtml = true;
                ////这边邮件的内容就可以用html标签（img）来插入图片
                ////attachment.contendid为附件固定的id
                ////cid:邮件BASE64编码的某个位置.然后从这个位置上读图片的数据
                //message.Body += "<br/><br/><img src=\"cid:" + attachment.ContentId + "\"/>";

                #endregion

                #endregion
            };

            // 多收件人
            foreach (var item in info.To)
            {
                message.To.Add(new MailAddress(item));
            }

            // 多抄送人
            foreach (var item in info.CC ?? new List<string>())
            {
                message.To.Add(new MailAddress(item));
            }

            // 附件
            foreach (var item in info.Attachments ?? new List<string>())
            {
                //发送附加件
                message.Attachments.Add(new Attachment(item));
            }

            try
            {
                //初始化SMTP类
                var smtp = new SmtpClient(emailInfo.SendingServer)
                {
                    //开启安全连接
                    EnableSsl = emailInfo.IsSSL,
                    //创建用户凭证
                    Credentials = new NetworkCredential(emailInfo.EmailAccount, emailInfo.PassWord),
                    //使用网络传送
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                
                //发送邮件
                smtp.Send(message);
            }
            catch (Exception e)
            {
                return new Result(false, "邮件发送异常，请检查邮箱配置，具体异常原因请查看日志！",e.ToString());
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
            var info = GetEmailAccountInfo();

            return new Result(info == null, info == null ? "获取邮箱相关信息失败，信息未配置！" : "", info);
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

        /// <summary>
        /// 获取邮箱登录相关信息
        /// </summary>
        /// <returns></returns>
        private EmailAccountInfo GetEmailAccountInfo()
        {
            var sysValue = _context.Sys_ConfigValues.FirstOrDefault(x => x.Key == (int)SystemCfgType.EmailAccount);
            if (sysValue == null || string.IsNullOrEmpty(sysValue.Property0)) return null;
            var info = JsonConvert.DeserializeObject<EmailAccountInfo>(sysValue.Property0);
            return info;
        }
    }
}
