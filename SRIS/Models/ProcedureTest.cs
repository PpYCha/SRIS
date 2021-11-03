namespace SRIS.Models
{
    public class ProcedureTest
    {
        public int Pt_id { get; internal set; }
        public string PrecedureDetails { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}