namespace CHINTAI.Models
{
    public class CrimeRiskScore
    {

        public int Id { get; set; }



        public int LocationId { get; set; }



        public Location? Location { get; set; }



        public double RiskPercentage { get; set; }



        public string RiskLevel { get; set; }



        public DateTime CalculatedDate { get; set; }
            = DateTime.Now;


    }
}
