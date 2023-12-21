﻿using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Ticket
    {

        [Key]
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public int FlightID { get; set; }
        public int TicketNum { get; set; } //Alinan bilet sayisi

    }
}
