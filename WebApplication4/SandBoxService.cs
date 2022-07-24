using Tinkoff.InvestApi;
using Tinkoff.InvestApi.V1;

namespace WebApplication4
{
    public class SandBoxService
    {
        private readonly SandboxService.SandboxServiceClient _sandBoxServiceClient;

        public SandBoxService(InvestApiClient investApi)
        {
            _sandBoxServiceClient = investApi.Sandbox;
        }

        public string GetInfo()
        {
            var request = new GetAccountsRequest();

            var accounts = _sandBoxServiceClient.GetSandboxAccounts(request);

            return accounts.Accounts.First().Id;
        }

    }
}
