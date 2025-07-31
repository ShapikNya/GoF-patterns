using Observer.Classes;
WeatherStation station = new WeatherStation(); 

Console.WriteLine("Температура 5 C");

station.AddObserver(new PhoneDisplay(station));
station.AddObserver(new LEDDisplay(station));

Console.WriteLine("Изменение температуры: 8 C");
station.SetTemperature(8);