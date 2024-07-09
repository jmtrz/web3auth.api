using web3auth.api.Handler;

namespace web3auth.api.Endpoints;

public static class Web3authEndpoint
{
    public static RouteGroupBuilder Web3AuthGroup(this RouteGroupBuilder group)
    {
        group.MapGet("/account", Web3authHandler.GetAccountAsync);

        return group;
    }
}
