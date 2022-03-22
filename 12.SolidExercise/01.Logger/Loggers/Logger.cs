namespace _01.Logger.Loggers 
{
    using System;
    using _01.Logger.Appenders;
    
    public class Logger : ILogger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; }

        public void Error(string message)
         => Log("Error", message);

        public void Info(string message)
         => Log("Info", message);

        public void Warning(string message)
         => Log("Warning", message);
    
        private void Log(string level, string message)
            => this.Appender.Append(DateTime.Now, level, message);
    }
}
