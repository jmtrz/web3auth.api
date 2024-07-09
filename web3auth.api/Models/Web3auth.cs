namespace web3auth.api.Models;

public class Web3auth
{
    public Data? data { get; set; }
    public bool Success { get; set; }
}

public class Data
{
    public string evmAddress { get; set; } = string.Empty;
    public string X { get; set; }
    public string Y { get; set; }
    public bool isMfaEnabled { get; set; } = false;
}
