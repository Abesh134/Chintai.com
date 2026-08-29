using System.ComponentModel.DataAnnotations;

namespace CHINTAI.Models
{
    public class CrimeReport
    {

        public int Id { get; set; }



        // User who submitted report

        public string? UserId { get; set; }



        public int CrimeCategoryId { get; set; }


        public CrimeCategory? CrimeCategory { get; set; }



        public int LocationId { get; set; }


        public Location? Location { get; set; }



        [Required]
        [MaxLength(200)]
        public string Title { get; set; }



        [MaxLength(2000)]
        public string? Description { get; set; }



        public DateTime CrimeDate { get; set; }



        public TimeSpan CrimeTime { get; set; }



        public double Latitude { get; set; }



        public double Longitude { get; set; }



        public string Status { get; set; } = "Pending";



        public DateTime CreatedDate { get; set; }
            = DateTime.Now;



        public ICollection<CrimeImage>? Images { get; set; }

    }
}
