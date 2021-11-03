namespace SRIS.Models
{
    public class UnitSpecification
    {
        public int Us_id { get; internal set; }
        public string ComponentName { get; set; }
        public string ComponentSpec { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}