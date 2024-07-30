// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQProducer;
using System.Text;
using System.Text.Json.Serialization;

var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};


using var connection = factory.CreateConnection();

using var channel = connection.CreateModel();
QueueProducer.Publish(channel);
Console.WriteLine("Hello, World!");
