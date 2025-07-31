using Command.Classes;

Console.WriteLine("Text Editor:");
Receiver textEditor = new Receiver();
textEditor.text = "Hello";

Console.WriteLine($"Text: {textEditor.text}");

Console.WriteLine("Выполнение команды WriteText - world");
WriteTextCommand command1 = new WriteTextCommand(textEditor, "world");
/*WriteTextCommand command2 = new WriteTextCommand(textEditor, "WORLD");
WriteTextCommand command3 = new WriteTextCommand(textEditor, "world");*/

Console.WriteLine("Выполнение команды...");
Invoker invoker = new Invoker();
invoker.AddCommand(command1);
/*invoker.AddCommand(command2);
invoker.AddCommand(command3);*/
invoker.ExecuteCommand();

Console.WriteLine($"Text: {textEditor.text}");

Console.WriteLine("Отмена операции");
invoker.UndoLast();
Console.WriteLine($"Text: {textEditor.text}");