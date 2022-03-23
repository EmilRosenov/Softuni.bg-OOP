namespace _02.LoggerExtensionPart1.Appenders
{
    using _02.LoggerExtensionPart1.Layouts;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(
            DateTime dateTime,
            string errorLevel,
            string message)
        {
            string output = string.Format(
                this.Layout.Format,
                dateTime,
                errorLevel,
                message);

            Console.WriteLine(output);
        }
    }
}
