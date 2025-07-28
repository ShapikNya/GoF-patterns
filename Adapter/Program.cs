using Adapter.Classes;
using Adapter.Interfaces;

Console.WriteLine("LegacySoundAdapter: ");

IAudioPlayer player = new LegacySoundAdapter();
player.Play("some music");
