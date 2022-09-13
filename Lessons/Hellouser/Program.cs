internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}");
    }
}