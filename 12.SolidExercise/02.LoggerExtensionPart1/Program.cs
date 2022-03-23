namespace _02.LoggerExtensionPart1
{
    using _02.LoggerExtensionPart1.Appenders;
    using _02.LoggerExtensionPart1.Layouts;
    using _02.LoggerExtensionPart1.LogFiles;
    using _02.LoggerExtensionPart1.Loggers;
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);

            ILogFile file = new LogFile();
            IAppender fileAppender = new FileAppender(simpleLayout, file);

            ILogger logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info("User Pesho successfully registered.");

        }
    }
}
