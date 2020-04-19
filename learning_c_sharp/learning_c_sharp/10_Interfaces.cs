using System;
namespace learning_c_sharp
{
    public interface ILogger
    {
        public void LogError(string message);
        public void LogInfo(string message);
    }

    public class Logger: ILogger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class FileLogger: ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Writting log to file");
        }

        public void LogError(string message)
        {
            Console.WriteLine("Writting error to file");
        }
    }

    public class Installer
    {
        private readonly ILogger _logger;

        public Installer(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInfo("Running installer at " + DateTime.Now);
            _logger.LogInfo("Finished installing at " + DateTime.Now);
        }

        public void Error()
        {
            _logger.LogError("An unknown error occured during installation");
        }
    }
}
