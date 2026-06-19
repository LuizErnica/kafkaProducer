using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer =
    new ProducerBuilder<Null, string>(config)
    .Build();

var random = new Random();

while (true)
{
    double temperature =
        Math.Round(random.NextDouble() * 40, 1);

    string message =
        $"Temperature={temperature}";

    var result =
        await producer.ProduceAsync(
            "Temperature_topic",
            new Message<Null, string>
            {
                Value = message
            });

    Console.WriteLine(
        $"Sent: {message} | " +
        $"Partition: {result.Partition} | " +
        $"Offset: {result.Offset}");

    await Task.Delay(2000);
}
