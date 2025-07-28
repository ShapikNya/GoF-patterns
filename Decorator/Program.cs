using Decorator.Classes;
using Decorator.Interfaces;

Console.WriteLine("Espresso with 2x sugar and 1x milk");

ICoffee myCoffee = new MilkDecorator(new SugarDecorator(new SugarDecorator(new Espresso())));

Console.WriteLine("This coffee cost: " + myCoffee.GetCost());
Console.WriteLine("Coffee consist: " + myCoffee.GetDescription());  
