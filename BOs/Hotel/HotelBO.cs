using DTOs.Hotel;
using SmartTrip.DAL;
using SmartTrip.DAL.Core;
using SmartTrip.DAL.EF;

using System.Collections.Generic;

namespace BOs.Hotel
{
    public sealed class HotelBO
    {
        private readonly IUnitOfWork unitOfWork;

        public HotelBO()
        {
            unitOfWork = new UnitOfWork(new ApplicationContext());
        }

        public IEnumerable<HotelDTO> GetHotels()
         => new List<HotelDTO>
            {
                new HotelDTO
                {
                    Name = "Hilton",
                    Address = "USA"
                },
                new HotelDTO
                {
                    Name = "Luma Hotel"
                }
            };

    }
}
