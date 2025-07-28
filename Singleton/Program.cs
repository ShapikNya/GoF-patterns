using Singleton.Classes;

Console.WriteLine("Logger data:");

Logger.Instance.Log("Create database");

Logger.Instance.Log("Create table");

Console.WriteLine(Logger.Instance.ToString());
