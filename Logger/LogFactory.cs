namespace Logger
{
    public class LogFactory
    {
        private string? FileLoggerPath;

        public BaseLogger? CreateLogger(string className)
        {
            if (FileLoggerPath is string valueOfFileLoggerPath)
            {
                return new FileLogger(valueOfFileLoggerPath) {
                    ClassName = className
                };
            }

            return null;
        }

        public void ConfigureFileLogger(string fileLoggerPath)
        {
            FileLoggerPath = fileLoggerPath;
        }
    }
}
