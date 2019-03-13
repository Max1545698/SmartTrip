using EasyNetQ;

using Microservice;

namespace HotelMicroservice
{
    public sealed class HotelMicroservice : BaseMicroservice
    {
        public HotelMicroservice(IBus bus)
            : base(bus)
        {

        }
    }
}
