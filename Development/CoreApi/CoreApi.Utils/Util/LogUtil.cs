/*********************************************************************************** 
 *   Filename :LogUtil  
 *   Date:2020/07/23 17:27:25 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:27:25: Created! 
 ************************************************************************************/

using System;
using System.Diagnostics;
using log4net;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace CoreApi.Utils.Util
{
    public static class LogUtil
    {
        public static string GetLogFile()
        {
            log4net.Appender.IAppender[] appenders = LogManager.GetRepository("").GetAppenders();
            foreach (var ac in appenders)
            {
                // 这里我只对RollingFileAppender类型做修改 
                log4net.Appender.RollingFileAppender rfa = ac as log4net.Appender.RollingFileAppender;
                if (null != rfa)
                {
                    var fileName = string.Empty;
                    return System.IO.Path.GetFullPath(rfa.File);
                }
            }

            return string.Empty;
        }

        public static void FlushLogFile()
        {
            //log4net.Appender.IAppender[] appenders = LogManager.GetRepository().GetAppenders();
            //foreach (var ac in appenders)
            //{
            //    // 这里我只对RollingFileAppender类型做修改 
            //    log4net.Appender.RollingFileAppender rfa = ac as log4net.Appender.RollingFileAppender;
            //    if (null != rfa)
            //    {                    
            //        rfa.Writer.Flush();
            //    }
            //}
        }

        public static void Debug(string message, Exception ex = null)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsDebugEnabled)
            {
                logger.Debug(message, ex);
            }
        }

        public static void Info(string message, Exception ex = null)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsInfoEnabled)
            {
                logger.Info(message, ex);
            }
        }

        public static void Warn(string message, Exception ex = null)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsWarnEnabled)
            {
                logger.Warn(message, ex);
            }
        }

        public static void Error(Exception ex)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsErrorEnabled)
            {
                logger.Error(null, ex);
            }
        }

        public static void Error(string message, Exception ex = null)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsErrorEnabled)
            {
                logger.Error(message, ex);
            }
        }

        public static void Fatal(Exception ex)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsFatalEnabled)
            {
                logger.Fatal(null, ex);
            }
        }

        public static void Fatal(string message, Exception ex = null)
        {
            var logger = LogManager.GetLogger(GetInvokeType());

            if (logger.IsFatalEnabled)
            {
                logger.Fatal(message, ex);
            }
        }

        public static Type GetInvokeType()
        {
            var stacks = new StackTrace().GetFrames();
            if (stacks != null && stacks.Length > 2)
            {
                var type = stacks[2].GetMethod().ReflectedType;
                return type;
            }

            return typeof(LogUtil);
        }
    }
}
