namespace _03.LoggerExtensionPart2
{
    using System;
    using Appenders;
    using Layouts;
    using Loggers;
    using ReportLevels;

    public class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");


        }
    }
}
