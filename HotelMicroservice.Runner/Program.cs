using System;

using EasyNetQ;

namespace HotelMicroservice.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bus = RabbitHutch.CreateBus("host=localhost");
                new HotelMicroservice(bus);
                Console.WriteLine("HotelMicroservice is running");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception was thrown: " + ex.Message);
            }
        }
    }
}
