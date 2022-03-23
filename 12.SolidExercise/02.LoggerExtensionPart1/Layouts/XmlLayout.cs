namespace _02.LoggerExtensionPart1.Loggers
{
    using System;
    using _02.LoggerExtensionPart1.Layouts;
    public class XmlLayout : Layout
    {
        public const string XmlLayoutFormat = @"<log>
    <date>{0}</date>
    <level>{1}</level>
    <message>{2}</message>
</log>";
        public XmlLayout() 
            : base(XmlLayoutFormat)
        {
        }
    } 
}
