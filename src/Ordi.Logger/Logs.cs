using NLog;
using NLog.Config;
using System;
using System.Globalization;
using System.IO;

namespace Ordi
{
    public class Logs
    {
        private static readonly Logger logger;

        static Logs()
        {
            logger = LogManager.GetCurrentClassLogger();
            var _Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings", "NLog.config");
            LogManager.Configuration = new XmlLoggingConfiguration(_Path);
        }

        public static void LogWrite(string msg, LogLevel logLevel = LogLevel.Info)
        {

        }

        /// <summary>
        /// 调试
        /// </summary>
        /// <param name="msg"></param>
        public static void Debug(string msg)
        {
            LogEventInfo _Info = new LogEventInfo(NLog.LogLevel.Debug, logger.Name, msg);
            _Info.Properties["AppName"] = "platform";
            logger.Log(_Info);
        }

        public static void Debug(string msg, Exception e)
        {
            var _Debug = new LogEventInfo(NLog.LogLevel.Debug, logger.Name, CultureInfo.InvariantCulture, msg, new object[] { }, e);
            _Debug.Properties["AppName"] = "platform";
            logger.Log(_Debug);
        }

        /// <summary>
        /// 信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Info(string msg)
        {
            logger.Info(msg);
        }

        public static void Info(string msg, Exception e)
        {
            logger.Info(e, msg, new object[] { });
        }

        /// <summary>
        /// 警告
        /// </summary>
        /// <param name="msg"></param>
        public static void Warn(string msg)
        {
            logger.Warn(msg);
        }

        public static void Warn(string msg, Exception e)
        {
            logger.Warn(e, msg, new object[] { });
        }

        /// <summary>
        /// 错误
        /// </summary>
        /// <param name="msg"></param>
        public static void Error(string msg)
        {
            logger.Error(msg);
        }

        public static void Error(string msg, Exception e)
        {
            logger.Error(e, msg, new object[] { });
        }

        /// <summary>
        /// 致命
        /// </summary>
        /// <param name="msg"></param>
        public static void Fatal(string msg)
        {
            logger.Fatal(msg);
        }

        public static void Fatal(string msg, Exception e)
        {
            logger.Fatal(e, msg, new object[] { });
        }
    }
}
