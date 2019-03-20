using System.Collections.Generic;

using BOs.Hotel;
using DTOs.Hotel;


namespace Facade
{
    public sealed class HotelFacade : BaseFacade
    {
        private readonly HotelBO hotelBO;

        public HotelFacade() => 
            hotelBO = new HotelBO();
        
            

        public IEnumerable<HotelDTO> GetHotels()
        => hotelBO.GetHotels();

    }
}
