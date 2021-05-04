using log4net;

namespace Logger
{
    public class LoggerManager
    {
        private static readonly ILog log = LogManager.GetLogger("Orasqualia Log");
        private LoggerManager() { }
        public static void Log(string message, LogType logType = LogType.Info)
        {
            switch (logType)
            {
                case LogType.Info:
                    log.Info(message);
                    break;
                case LogType.Error:
                    log.Error(message);
                    break;
                case LogType.Warning:
                    log.Warn(message);
                    break;
            }
        }
    }
}
