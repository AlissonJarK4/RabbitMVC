using System;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbitApp.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult SendMessage()
        {
            var factory = new ConnectionFactory() { HostName = "docker", UserName = "admin", Password = "admin" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare
                (
                    queue: "test",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                string msg = "Hello Warudo!";
                var body = Encoding.UTF8.GetBytes(msg);

                channel.BasicPublish
                (
                    exchange: "",
                    routingKey: "test",
                    basicProperties: null,
                    body: body
                );

                Console.WriteLine($"Sent {msg}");
            }
            return new EmptyResult();
        }

        public ActionResult ReceiveMessage()
        {
            Console.WriteLine("Creating consumer");
            var factory = new ConnectionFactory(){ HostName = "docker", UserName = "admin", Password = "admin" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare
                (
                    queue: "test",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                };
                channel.BasicConsume
                (
                    queue: "test",
                    autoAck: true,
                    consumer: consumer
                );

                Console.WriteLine("Consumer ready");
                Console.ReadLine();
            }
            return new EmptyResult();
        }
    }
}
