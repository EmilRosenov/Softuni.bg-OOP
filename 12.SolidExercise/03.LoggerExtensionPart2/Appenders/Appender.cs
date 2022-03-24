
namespace _03.LoggerExtensionPart2.Appenders
{
    using System;
    using Layouts;
    using ReportLevels;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(
            DateTime dateTime,
            ReportLevel reportLevel,
            string message);
        
    }
}
