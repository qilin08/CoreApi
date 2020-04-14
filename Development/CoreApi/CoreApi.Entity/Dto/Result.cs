﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity.Dto
{
    /// <summary>
    /// 返回结果
    /// </summary>
    public class Result
    {
        private bool isSuccess = true;

        private string message = string.Empty;

        private int code = 200;

        private object data;

        public Result()
        { }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess
        {
            get { return isSuccess; }
            set { isSuccess = value; }
        }

        /// <summary>
        /// 如果不成功的话,返回的错误消息
        /// </summary>
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        /// <summary>
        /// 返回结果状态码
        /// </summary>
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public object Data
        {
            get { return data; }
            set { data = value; }
        }

        public Result(bool isSuccess, string message)
        {
            this.isSuccess = isSuccess;
            this.message = message;
        }

        public Result(bool isSuccess, string message,object data)
        {
            this.isSuccess = isSuccess;
            this.message = message;
            this.data = data;
        }
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T> : Result where T : class, new()
    {
        public Result()
        {
            this.Value = new T();
        }
        public T Value { get; set; }
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultStruct<T> : Result where T : struct
    {
        public ResultStruct()
        {
            this.Value = new T();
        }
        public T Value { get; set; }
    }
}