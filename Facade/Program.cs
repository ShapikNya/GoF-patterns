using Facade.Classes;

Console.WriteLine("HomeTheater in activated: ");
HomeTheaterFacade theater = new HomeTheaterFacade(new DVDPlayer(), new Lights(), new Projector(), new SoundSystem());
theater.WatchMovie();

Console.WriteLine();
Console.WriteLine("HomeTheater is stopped");
theater.EndMovie();
