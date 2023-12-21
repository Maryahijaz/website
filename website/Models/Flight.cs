using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Flight
    {

        [Key]
        public int FlightId { get; set; }

        [StringLength(6)]
        public int FlightNum { get; set; }
        public int FlightCapacity { get; set; }
        public int FlightTime { get; set; }
        public int PassengerNum { get; set; }
        public string FlightDestination { get; set; }
        public string FlightDepartue { get; set; }
        public string FlightCompany{ get; set; }
        public DateTime FlightDepartueDate { get; set; }
        public DateTime FlightDestinationDate { get; set; }
        public TimeSpan FlightDestinationTime { get; set; }
        public TimeSpan FlightDepartueTime { get; set; }

        [StringLength(120)]
        public double EconomyClass { get; set; }

        [StringLength(80)]
        public double BusinessClass { get; set; }
        

    }
}
