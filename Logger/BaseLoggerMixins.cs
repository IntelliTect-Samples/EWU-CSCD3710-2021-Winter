using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger? baseLogger, string message, params object[] messageInterpolation)
        {
            if (baseLogger is BaseLogger valueOfBaseLogger)
            {
                valueOfBaseLogger.Log(LogLevel.Error, string.Format(message, messageInterpolation));
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void Warning(this BaseLogger? baseLogger, string message, params object[] messageInterpolation)
        {
            if (baseLogger is BaseLogger valueOfBaseLogger)
            {
                valueOfBaseLogger.Log(LogLevel.Warning, string.Format(message, messageInterpolation));
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public static void Information(this BaseLogger? baseLogger, string message, params object[] messageInterpolation)
        {
            if (baseLogger is BaseLogger valueOfBaseLogger)
            {
                valueOfBaseLogger.Log(LogLevel.Information, string.Format(message, messageInterpolation));
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void Debug(this BaseLogger? baseLogger, string message, params object[] messageInterpolation)
        {
            if (baseLogger is BaseLogger valueOfBaseLogger)
            {
                valueOfBaseLogger.Log(LogLevel.Debug, string.Format(message, messageInterpolation));
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
