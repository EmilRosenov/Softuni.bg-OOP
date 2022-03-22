
namespace _01.Logger
{
    using System;
    using _01.Logger.Appenders;
    using _01.Logger.Layouts;
    using _01.Logger.Loggers;


    public class Program
    {
        public static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            //Console.WriteLine(string.Format(simpleLayout.Format,"13","14","15"));
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.Append(DateTime.Now, "Error", "Hi");
            ILogger logger = new Logger(consoleAppender);
            logger.Error("Error parsing JSON.");
            logger.Info("User Pesho successfully registered.");

        }
    }
}
