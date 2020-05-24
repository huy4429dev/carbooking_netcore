using System;
using System.Collections.Generic;

namespace CarBooking.Models
{
    public class  CarImage
    {
        public int Id{get;set;}
        
        public string Url{get;set;}
        public double Size{get;set;}
        public int CarId{get;set;}
        public Car Car{get;set;}
        public DateTime Created_At{get;set;}
        public DateTime Updated_At{get;set;}

    }
}