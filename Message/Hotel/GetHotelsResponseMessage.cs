using System.Collections.Generic;

using DTOs.Hotel;


namespace Message.Hotel
{
    public sealed class GetHotelsResponseMessage
    {
        public IEnumerable<HotelDTO> Hotels { get; set; }
    }
}