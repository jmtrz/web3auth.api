using Microsoft.AspNetCore.Mvc;
using web3auth.api.Services;

namespace web3auth.api.Handler;

public static class Web3authHandler
{
    public static async Task<IResult> GetAccountAsync(
        [FromQuery] string verifier, 
        [FromQuery] string verifiedId, 
        [FromQuery] string authNetwork, 
        [FromQuery] string clientId, 
        [FromServices] IWeb3authService web3authService)
    {
        try
        {
            var response = await web3authService.GetAccount(verifier, verifiedId, authNetwork, clientId);
            return Results.Ok(response);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
