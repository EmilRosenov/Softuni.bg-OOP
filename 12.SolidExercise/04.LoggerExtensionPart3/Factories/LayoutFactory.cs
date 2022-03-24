namespace _04.LoggerExtensionPart3.Factories
{
    using System;
    using Layouts;


    public static class LayoutFactory
    {
        public static ILayout CreateLayout(string type)
        {
           
            ILayout layout = type switch
            {
                "SimpleLayout" => new SimpleLayout(),
                "XmlLayout" => new XmlLayout(),
                _ => throw new InvalidOperationException("Missing type")
            };
            
            return layout;
        }
    }
}
