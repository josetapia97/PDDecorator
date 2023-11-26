using DecoratorCoffee;
using DecoratorCoffee.Elements.CoffeAdds;
using DecoratorCoffee.Elements.CoffeTypes;

ICoffee cafecito = new SimpleCoffee();
Console.WriteLine($"{cafecito.GetDescription()} : ${cafecito.GetCost()}");

cafecito = new MilkDecorator(cafecito);
Console.WriteLine($"{cafecito.GetDescription()} : ${cafecito.GetCost()}");

cafecito = new WhippedCreamDecorator(cafecito);
Console.WriteLine($"{cafecito.GetDescription()} : ${cafecito.GetCost()}");