
namespace _01.Logger.Appenders
{
    using System;
    using _01.Logger.Layouts;
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
