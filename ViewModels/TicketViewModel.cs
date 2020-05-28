using System;
using System.ComponentModel.DataAnnotations;

namespace CarBooking.ViewModels
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string CarCode{get;set;}
        public string RouteName{get;set;}
        public string Phone {get;set;}
        public DateTime CreatedAt{get;set;}

    }
}