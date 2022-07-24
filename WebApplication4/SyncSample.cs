using Tinkoff.InvestApi;

namespace WebApplication4
{
    public class SyncSample : BackgroundService
    {
        private readonly InvestApiClient _investApi;
        private readonly IHostApplicationLifetime _lifetime;
        private readonly ILogger _logger;

        public SyncSample(ILogger<SyncSample> logger, InvestApiClient investApi, IHostApplicationLifetime lifetime)
        {
            _investApi = investApi;
            _lifetime = lifetime;
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            /*var userInfoDescription = new UsersServiceSample(_investApi).GetUserInfoDescription();
            _logger.LogInformation(userInfoDescription);*/

            var sandBoxInfo = new SandBoxService(_investApi).GetInfo();
            _logger.LogInformation(sandBoxInfo);

           /* var instrumentsDescription = new InstrumentsServiceSample(_investApi.Instruments)
                .GetInstrumentsDescription();
            _logger.LogInformation(instrumentsDescription);

            var operationsDescription = new OperationsServiceSample(_investApi)
                .GetOperationsDescription();
            _logger.LogInformation(operationsDescription);*/

            _lifetime.StopApplication();

            return Task.CompletedTask;
        }
    }
}
