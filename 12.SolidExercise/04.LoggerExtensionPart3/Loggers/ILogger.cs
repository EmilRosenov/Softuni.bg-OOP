namespace _04.LoggerExtensionPart3.Loggers
{
    using Appenders;
    

    public interface ILogger
    {
        IAppender[] Appenders { get; }
        //ReportLevel Reportlevel { get; }

        void Info(string message);
        void Warning(string message);
        void Error(string message);
        void Critical(string message);
        void Fatal(string message);

    }
}
