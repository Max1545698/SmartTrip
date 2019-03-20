using EasyNetQ;
using Facade;
using Message.Hotel;
using Microservice;

namespace HotelMicroservice
{
    public sealed class HotelMicroservice : BaseMicroservice
    {
        public HotelMicroservice(IBus bus)
            : base(bus)
        {
            Respond<GetHotelsMessage, GetHotelsResponseMessage>(OnGetHotelsMessage);
        }

        public GetHotelsResponseMessage OnGetHotelsMessage(GetHotelsMessage message)
        {
            var facade = new HotelFacade();

            var result = facade.ExecuteFacade(facade.GetHotels);

            var response = new GetHotelsResponseMessage()
            {
                Hotels = result
            };

            return response;
        }
    }
}
