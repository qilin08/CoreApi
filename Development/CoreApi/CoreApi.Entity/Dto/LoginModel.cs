﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.Entity.Dto
{
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
    }
}
