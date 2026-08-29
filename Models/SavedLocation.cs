namespace CHINTAI.Models
{
    public class SavedLocation
    {

        public int Id { get; set; }



        public string UserId { get; set; }



        public string LocationName { get; set; }



        public double Latitude { get; set; }



        public double Longitude { get; set; }



        public DateTime CreatedDate { get; set; }
            = DateTime.Now;


    }
}
