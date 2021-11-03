namespace SRIS.Models
{
    public class Recommendation
    {
        public int R_id { get; internal set; }
        public string RecommendationDetail { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}