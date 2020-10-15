using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi.Entity.Dto;
using CoreApi.IService.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Web.Controllers.Auth
{
    /// <summary>
    /// 用户认证相关控制器
    /// </summary>
    //[Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserMgr _userMgr;

        public AuthController(IUserMgr userMgr)
        {
            _userMgr = userMgr ?? throw new ArgumentNullException(nameof(userMgr));
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public Result Login(LoginModel model)
        {
            var result = new Result();
            var message = new StringBuilder();

            if (string.IsNullOrWhiteSpace(model.UserName)) { message.Append("请输入用户名；"); }
            if (string.IsNullOrWhiteSpace(model.PassWord)) { message.Append("请输入密码；"); }
            if (message.Length > 0) {
                result.IsSuccess = false;
                result.Message = message.ToString();
                return result;
            }

            // TODO: 登录验证 

            return result;
        }
    }
}
