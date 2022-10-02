using System.ComponentModel.DataAnnotations;

namespace TripsLog.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Accommodation { get; set; }

        public string AccommodationPhone { get; set; }

        public string AccommodationEmail { get; set; }

        public string ThingToDo1 { get; set; }

        public string ThingToDo2 { get; set; }

        public string ThingToDo3 { get; set; }

        public string Accommodations => this.Accommodation + " \n" + "Phone : " + this.AccommodationPhone + " | Email : " + this.AccommodationEmail;

        public string ThingsToDo => this.ThingToDo1 + "\n" + this.ThingToDo2 + "\n" + this.ThingToDo3;
    }
}
