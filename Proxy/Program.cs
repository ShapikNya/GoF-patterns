using Proxy.Classes;

Console.WriteLine("Получение файлов из FileService");
FileService fileService = new FileService();
CustomFileProxy proxy = new CustomFileProxy(fileService);

Console.WriteLine("Получение /c *Задержка 5 секунд");
Console.WriteLine(proxy.Open("/c", "123").ToString());

Console.WriteLine("Получение /c/folder *Задержка 5 секунд");
Console.WriteLine(proxy.Open("/c/folder", "321").ToString());

Console.WriteLine("Получение /c *Задержка 0 секунд");
Console.WriteLine(proxy.Open("/c", "123").ToString());

