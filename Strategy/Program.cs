using Strategy;

var context = new Context();
Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new StrategyA());
context.ExecuteBusinessLogic();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new StrategyB());
context.ExecuteBusinessLogic();
