using Builder.Classes;

UserBuilder builder = new UserBuilder();
builder.SetUsername("User_221010").SetPassword("qwerty123");
User user = builder.Build();

Console.WriteLine(user.Username + " " + user.Password);