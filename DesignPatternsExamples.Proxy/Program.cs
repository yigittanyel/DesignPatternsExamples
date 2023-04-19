

ILogger logger=new ProxyFileLogger(2);
logger.Log("Yigit");
logger.Log("Semih");
logger.Log("Yusuf");


public interface ILogger
{
    void Log(string message);
    void Log(IEnumerable<string> messages);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        message = $"[{DateTime.Now:dd.MM.yyyy}] - {message}";
        File.AppendAllText("log.txt", message);
    }

    public void Log(IEnumerable<string> messages)
    {
        File.AppendAllText("log.txt", string.Join(Environment.NewLine, messages));
    }
}

public class ProxyFileLogger : ILogger
{
    private readonly int logSize;
    private readonly FileLogger _fileLogger;
    private List<string> _messages;

    public ProxyFileLogger(int logSize)
    {
        this.logSize = logSize;
        _fileLogger = new FileLogger();
        _messages = new List<string>(capacity:logSize);
    }

    public void Log(string message)
    {
        _messages.Add(message);

        if (_messages.Count >= logSize)
        {
            _fileLogger.Log(_messages);
            _messages.Clear();
        }
    }

    public void Log(IEnumerable<string> messages)
    {
        _fileLogger.Log(messages);
    }
}