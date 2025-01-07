namespace ConsoleApp1;

internal partial class Program
{
    public readonly AccountService AccountService;

    public Program(AccountService accountService)
    {
        AccountService = accountService;

        Console.WriteLine(AccountService.ThisError);
        Console.WriteLine(AccountService.NoError1);
        Console.WriteLine(AccountService.NoError2);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}