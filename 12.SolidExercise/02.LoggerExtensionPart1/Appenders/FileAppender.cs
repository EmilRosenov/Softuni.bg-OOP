namespace _02.LoggerExtensionPart1.Appenders
{
    using System;
    using System.IO;
    using _02.LoggerExtensionPart1.Layouts;
    using _02.LoggerExtensionPart1.LogFiles;

    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(
                            DateTime dateTime,
                            string errorLevel,
                            string message)
        {
            string outputMessage = string.Format(
                this.Layout.Format,
                dateTime,
                errorLevel,
                message)
                +Environment.NewLine;

            this.logFile.Write(outputMessage);

            File.AppendAllText("../../../log.txt", outputMessage); 
            File.AppendAllText("../../../log.html", outputMessage);
        }
    }
}
