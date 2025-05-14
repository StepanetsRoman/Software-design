
namespace Adapter
{
    public interface ITarget
    {
        void Log(string message);
        void Error(string message);
        void Warn(string message);
    }

    public class Logger : ITarget
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[LOG] " + message);
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] " + message);
            Console.ResetColor();
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[WARN] " + message);
            Console.ResetColor();
        }
    }

    public class FileWriter
    {
        public void Write(string text)
        {
            File.AppendAllText("log.txt", text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText("log.txt", text + Environment.NewLine);
        }
    }

    public class FileLoggerAdapter : ITarget
    {
        private readonly FileWriter _fileWriter = new();

        public void Log(string message) => _fileWriter.WriteLine("[LOG] " + message);
        public void Error(string message) => _fileWriter.WriteLine("[ERROR] " + message);
        public void Warn(string message) => _fileWriter.WriteLine("[WARN] " + message);
    }
}
