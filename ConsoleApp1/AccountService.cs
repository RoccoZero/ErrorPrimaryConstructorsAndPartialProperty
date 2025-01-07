namespace ConsoleApp1;

using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

internal sealed partial class AccountService
{
    public partial string? ThisError
    {
        get
        {
            return "AAAA";
        }
    }

    public string? NoError2
    {
        get
        {
            return "AAAA";
        }
    }
}

internal sealed partial class AccountService(ConfigService configService)
{
    public partial string? ThisError { get; }

    public string? NoError1
    {
        get
        {
            return "AAAA";
        }
    }
}

internal class ConfigService
{
}