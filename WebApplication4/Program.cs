
using Microsoft.Extensions.Configuration.UserSecrets;
using WebApplication4;

//[assembly: UserSecretsId("d8c06331-547d-4683-9995-423f70518a8a")]

var builder = Host.CreateDefaultBuilder(args);

var host = builder
    .ConfigureServices((context, services) => 
    {
        services.AddHostedService<SyncSample>();

        services.AddInvestApiClient((_, settings) => 
        {
            settings.AccessToken = "t.CDA4jFOPRpLqf3_1jAl8wG552lvsYQqSyAlmxrC1I9VtM9CpjzwCGVfWvD7Bs3PNAjAyFVL71jK1VVg_UAA4tQ";

            context.Configuration.Bind(settings);

        });
    })
    .Build();  


host.Run();