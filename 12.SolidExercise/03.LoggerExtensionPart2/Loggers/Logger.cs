namespace _03.LoggerExtensionPart2.Loggers 
{
    using System;
    using Appenders;
    using ReportLevels;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders { get; }

       

        public void Info(string message)
         => Log(ReportLevel.Info, message);

        public void Warning(string message)
         => Log(ReportLevel.Warning, message);
        public void Error(string message)
        => Log(ReportLevel.Error, message);

        public void Critical(string message)
        => Log(ReportLevel.Critical, message);
        public void Fatal(string message)
        => Log(ReportLevel.Fatal, message);

        private void Log(ReportLevel reportLevel, string message)
        {

           
            foreach (var appender in this.Appenders)
            {
                if (reportLevel >= appender.ReportLevel)
                {
                    appender.Append(
                    DateTime.Now,
                    reportLevel,
                    message);
                }
               
            }
        }
    }
}
