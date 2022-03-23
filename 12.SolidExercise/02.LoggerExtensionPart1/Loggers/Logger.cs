namespace _02.LoggerExtensionPart1.Loggers 
{
    using System;
    using _02.LoggerExtensionPart1.Appenders;
    
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders { get; }

        public void Error(string message)
         => Log("Error", message);

        public void Info(string message)
         => Log("Info", message);

        public void Warning(string message)
         => Log("Warning", message);
    
        private void Log(string level, string message)
        {
            foreach (var appender in this.Appenders)
            {
                appender.Append(DateTime.Now,
                                level,
                                message);
            }
        }
            
    }
}
