using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using WeNeed1.Consumer.EmailHandler.Services;

try
{
    var factory = new ConnectionFactory
    {
        HostName = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "rabbitmq",
        Port = int.Parse(Environment.GetEnvironmentVariable("RABBITMQ_PORT") ?? "5672"),
        UserName = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest",
        Password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest",
    };

    Console.WriteLine("Attempting to connect to RabbitMQ...");

    using var connection = factory.CreateConnection();
    Console.WriteLine("Connected to RabbitMQ!");
    
    using var channel = connection.CreateModel();

    channel.QueueDeclare(queue: "reservation_cancelled",
        durable: false,
        exclusive: false,
        autoDelete: false,
        arguments: null);

    Console.WriteLine(" [*] Waiting for messages...");

    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine($" [x] Received: {message}");

        var emailService = new EmailService();
        emailService.SendEmail(message);
    };

    channel.BasicConsume(queue: "reservation_cancelled",
        autoAck: true,
        consumer: consumer);

    Console.WriteLine("Press [enter] to exit.");
    Thread.Sleep(Timeout.Infinite);

    channel.Close();
    connection.Close();
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    if (ex.InnerException != null)
    {
        Console.WriteLine($"INNER EXCEPTION: {ex.InnerException.Message}");
    }
    Console.WriteLine("Press any key to exit...");
    Thread.Sleep(Timeout.Infinite);
}