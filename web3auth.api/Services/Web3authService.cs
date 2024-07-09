using web3auth.api.Models;

namespace web3auth.api.Services;

public class Web3authService : IWeb3authService
{
    private readonly HttpClient _httpClient;
    public Web3authService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Web3auth> GetAccount(string verifier, string verifiedId, string authNetwork,string clientId)
    {
        var response = await _httpClient.GetFromJsonAsync<Web3auth>($"?verifier={verifier}&verifierId={verifiedId}&web3AuthNetwork={authNetwork}&clientId={clientId}");

        return response ?? new Web3auth();
    }
}
