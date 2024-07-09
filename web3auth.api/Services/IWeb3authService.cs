using web3auth.api.Models;

namespace web3auth.api.Services;

public interface IWeb3authService
{
    Task<Web3auth> GetAccount(string verifier, string verifiedId, string authNetwork, string clientId);
}
