namespace _01.Logger.Appenders
{
    using System;
    using _01.Logger.Layouts;
   

    public interface IAppender
    {
        
        ILayout Layout { get; }
        void Append(DateTime dateTime,
                      string errorLevel, // why not Enum?
                      string message);
    }
}
