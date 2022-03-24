namespace _04.LoggerExtensionPart3.LogFiles
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
