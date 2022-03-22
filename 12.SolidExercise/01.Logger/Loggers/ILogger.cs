namespace _01.Logger.Loggers
{
    using _01.Logger.Appenders;

    public interface ILogger
    {
        IAppender Appender { get; }

        void Info(string message);
        void Warning(string message);
        void Error(string message);

    }
}
