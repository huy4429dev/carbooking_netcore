using System;
using System.Collections.Generic;

namespace CarBooking.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarCode { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public int SeatNumber { get; set; }
        public int SeatNumberRest { get; set; }
        public StatusCar StatusCar { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<CarImage> CarImages { get; set; }

    }
}