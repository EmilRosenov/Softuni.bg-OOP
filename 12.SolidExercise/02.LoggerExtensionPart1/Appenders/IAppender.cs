namespace _02.LoggerExtensionPart1.Appenders
{
    using System;
    using _02.LoggerExtensionPart1.Layouts;
   

    public interface IAppender
    {
        
        ILayout Layout { get; }
        void Append(DateTime dateTime,
                      string errorLevel, // why not Enum?
                      string message);
    }
}
