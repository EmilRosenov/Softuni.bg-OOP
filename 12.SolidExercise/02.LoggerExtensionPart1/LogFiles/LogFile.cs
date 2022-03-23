namespace _02.LoggerExtensionPart1.LogFiles
{
    using System;
    using System.Text;
    using System.Linq;

    public class LogFile : ILogFile
    {
        private readonly StringBuilder stringBuilder;
        public LogFile()
            => this.stringBuilder = new StringBuilder();
        public int Size
            => this.stringBuilder
            .ToString()
            .Where(char.IsLetter)
            .Sum(x => x);

        public void Write(string message)
           => this.stringBuilder.Append(message);
    }
}
