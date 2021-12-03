using ProjectCinema.App.Domain;

namespace ProjectCinema.Models
{
    public class SearchResultViewModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MinutesOfPlay { get; set; }
        public string Genre { get; set; }
        public int YearOfMaking { get; set; }
        public Movie Movie { get; set; }
        public ScreeningTime ScreeningTime { get; set; }
        public Image Image { get; set; }
        public TicketViewModel Ticket { get; set; }

    }
}
