﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int UserID { get; set; }

        [ForeignKey("Id")]
        public int MovieId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public Movie? Movie { get; set; }
        public User? User { get; set; }
        /*public string? Title { get; set; }*/
    }

}