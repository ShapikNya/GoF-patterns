using Factory_Method.Classes.Base;
using Factory_Method.Classes.NotificationCreator;

Console.WriteLine("Выберите тип уведомления");
Console.WriteLine("1 - Email");
Console.WriteLine("2 - Push");
Console.WriteLine("3 - SMS");

try
{
    int type;
    type = Convert.ToInt32(Console.ReadLine());

    NotificationCreator creator;

    switch (type)
    {
        case 1:
            {
                creator = new EmailNotificationCreator();
                return;
            }
        case 2:
            {
                creator = new PushNotificationCreator();
                return;
            }
        case 3:
            {
                creator = new SmsNotificationCreator(); 
                return;
            }
    }

    //creator.CreateNotification().Send("some text");

}
catch
{
    Console.WriteLine("Неверный ввод");
}
