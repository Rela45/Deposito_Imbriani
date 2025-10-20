﻿public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}

public class UserService
{
    private readonly ILogger _logger;

    public UserService(ILogger logger)  //constructor injection
    {
        _logger = logger;
    }

    public void CreateUser(string name)
    {
        _logger.Log($"User '{name}' created.");
    }
}
class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        UserService userService = new UserService(logger);
        userService.CreateUser("Alice");
    }
}
