namespace CHINTAI.Models
{
    public class CrimeImage
    {

        public int Id { get; set; }



        public int CrimeReportId { get; set; }



        public CrimeReport? CrimeReport { get; set; }



        public string ImagePath { get; set; }



        public DateTime UploadedDate { get; set; }
            = DateTime.Now;


    }
}
