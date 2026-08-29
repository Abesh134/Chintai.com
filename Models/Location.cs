using System.ComponentModel.DataAnnotations;

namespace CHINTAI.Models
{
    public class Location
    {

        public int Id { get; set; }



        [Required]
        public string Division { get; set; }



        [Required]
        public string District { get; set; }



        [Required]
        public string AreaName { get; set; }



        public double Latitude { get; set; }



        public double Longitude { get; set; }



        public ICollection<CrimeReport>? CrimeReports { get; set; }



        public ICollection<CrimeRiskScore>? CrimeRiskScores { get; set; }

    }
}
