namespace _03.LoggerExtensionPart2.LogFiles
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
