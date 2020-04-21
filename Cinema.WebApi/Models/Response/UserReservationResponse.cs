namespace Cinema.WebApi.Models.Response
{
    public class UserReservationResponse
    {
        public string ReservationId { get; set; }
        public string MovieTitle { get; set; }
        public string DateTime { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Price { get; set; }
    }
}
