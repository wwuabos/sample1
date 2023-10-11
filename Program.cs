// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("1.");
Console.WriteLine(typeof(System.Data.CommandBehavior).Assembly.Location);
Console.WriteLine("2.");
Console.WriteLine(typeof(System.Collections.ArrayList).Assembly.Location);
Console.WriteLine("3.");
Console.WriteLine(typeof(HashSet<>).Assembly.Location);
Console.WriteLine("4.");
foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
{
	Console.WriteLine(assembly.Location);
}
Console.ReadKey();