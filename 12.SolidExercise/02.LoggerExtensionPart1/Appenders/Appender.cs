
namespace _02.LoggerExtensionPart1.Appenders
{
    using System;
    using _02.LoggerExtensionPart1.Layouts;
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public abstract void Append(
            DateTime dateTime,
            string errorLevel,
            string message);
        
    }
}
