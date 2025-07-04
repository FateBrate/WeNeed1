namespace WeNeed1.Service.Impl
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class SportCenterRecommenderStartupTrainer : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public SportCenterRecommenderStartupTrainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var trainer = scope.ServiceProvider.GetRequiredService<SportsCenterRecommenderService>();

            try
            {
                await trainer.TrainModelAsync();
                Console.WriteLine("Preporuke trenirane prilikom pokretanja aplikacije.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom treniranja preporuka: " + ex.Message);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }

}
