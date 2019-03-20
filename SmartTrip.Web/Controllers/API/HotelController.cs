using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using EasyNetQ;

using Message.Hotel;


namespace SmartTrip.Web.Controllers.API
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        private readonly IBus bus;

        public HotelController(IBus bus)
        => this.bus = bus;

        [HttpPost]
        public async Task<IActionResult> GetHotels()
        {
            var result = await bus.RequestAsync<GetHotelsMessage, GetHotelsResponseMessage>(new GetHotelsMessage());
            return Ok(result);
        }
    }
}