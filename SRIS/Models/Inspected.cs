namespace SRIS.Models
{
    public class Inspected
    {
        public int I_id { get; internal set; }
        public string InspectedName { get; set; }
        public string InspectedPosition { get; set; }

        public int? II_ID { get; internal set; }
        public InspectionInfo InspectionInfo { get; internal set; }
    }
}