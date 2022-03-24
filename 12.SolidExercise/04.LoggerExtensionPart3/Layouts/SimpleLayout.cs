namespace _04.LoggerExtensionPart3.Layouts
{
    public class SimpleLayout : Layout
    {
        private const string SimpleLayoutFormat = "{0} - {1} - {2}";
        public SimpleLayout() 
             : base(SimpleLayoutFormat)
        {
        }
    }
}
