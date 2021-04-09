using System.IO;

namespace CSDemo.Extensibility
{
    class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Message(message,"ERROR: ");
        }

        public void LogInfo(string message)
        {
            Message(message,"INFO: ");
        }

        private void Message(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + message);
            }
        }
    }
}