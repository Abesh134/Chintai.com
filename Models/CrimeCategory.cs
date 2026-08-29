using System.ComponentModel.DataAnnotations;

namespace CHINTAI.Models
{
    public class CrimeCategory
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string? Description { get; set; }


        // 1 = Low
        // 5 = Extremely Dangerous

        public int SeverityLevel { get; set; }



        public ICollection<CrimeReport>? CrimeReports { get; set; }

    }
}
