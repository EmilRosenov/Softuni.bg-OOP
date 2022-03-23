namespace _02.LoggerExtensionPart1.Loggers
{
    using _02.LoggerExtensionPart1.Appenders;

    public interface ILogger
    {
        IAppender[] Appenders { get; }

        void Info(string message);
        void Warning(string message);
        void Error(string message);

    }
}
