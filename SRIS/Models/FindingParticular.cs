using System.Collections.Generic;

namespace SRIS.Models
{
    public class FindingParticular
    {
        public int Fp_id { get; internal set; }
        public string Particular { get; set; }
        public string Condition { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}