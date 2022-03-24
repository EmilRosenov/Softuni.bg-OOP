namespace _03.LoggerExtensionPart2.Appenders
{
    using System;
    using Layouts;
    using ReportLevels;

    public interface IAppender
    {
        
        ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }
        void Append(
            DateTime dateTime,
            ReportLevel reportLevel, // why not Enum?
            string message);
    }
}
