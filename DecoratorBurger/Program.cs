using DecoratorBurger;
using DecoratorBurger.Elements.BurgerAdds;
using DecoratorBurger.Elements.BurgerTypes;

IBurger cuartodelibra = new ClassicBurger();
cuartodelibra = new BaconDecorator(cuartodelibra);
Console.WriteLine($"{cuartodelibra.GetDescription()} : ${cuartodelibra.GetCost()}");
cuartodelibra = new CheeseDecorator(cuartodelibra);
Console.WriteLine($"{cuartodelibra.GetDescription()} : ${cuartodelibra.GetCost()}");
cuartodelibra = new TomatoDecorator(cuartodelibra);
Console.WriteLine($"{cuartodelibra.GetDescription()} : ${cuartodelibra.GetCost()}");
cuartodelibra = new SauceDecorator(cuartodelibra);
Console.WriteLine($"{cuartodelibra.GetDescription()} : ${cuartodelibra.GetCost()}");
