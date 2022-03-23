using System;
using System.Collections.Generic;
using System.Text;

namespace _02.LoggerExtensionPart1.LogFiles
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
