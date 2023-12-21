using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace website.Models
{
    public class Ticket
    {

        [Key]
        public int TicketId { get; set; }

        [ForeignKey("PassengerId")]
        public int PassengerId { get; set; }
        public Passenger PassengerInformation { get; set; }

        [ForeignKey("FlightId")]
        public int FlightId { get; set; }
        public Flight FlightInformation { get; set; }

        [StringLength(8)]
        public int TicketNum { get; set; } //Alinan bilet sayisi

        [StringLength(200)]
        public double SeatNum { get; set; }
    }
}
