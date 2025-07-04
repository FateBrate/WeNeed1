using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WeNeed1.Service.Impl
{
    public class TeamRecommenderStartupTrainer : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public TeamRecommenderStartupTrainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var trainer = scope.ServiceProvider.GetRequiredService<TeamRecommenderService>();

            try
            {
                await trainer.TrainModelAsync();
                Console.WriteLine("Team recommendations trained at application startup.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error training team recommendations: " + ex.Message);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
