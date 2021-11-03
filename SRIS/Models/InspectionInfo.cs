using System;
using System.Collections.Generic;

namespace SRIS.Models
{
    public class InspectionInfo
    {
        public int Ii_id { get; internal set; }
        public string RequestingOffice { get; set; }
        public string RequestedBy { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ReceivedPosition { get; set; }
        public string TypeOfUnit { get; set; }
        public string ComplaintOnUnit { get; set; }
        public string PropertyNumber { get; set; }
        public string UnitReleasedTo { get; set; }
        public string PositionUnitReleasedTo { get; set; }
        public DateTime? DateReleased { get; set; }
        public ICollection<FindingParticular> FindingParticular { get; internal set; }
        public ICollection<ProcedureTest> ProcedureTest { get; internal set; }
        public ICollection<UnitSpecification> UnitSpecification { get; internal set; }
        public ICollection<Inspected> Inspected { get; internal set; }
        public ICollection<Recommendation> Recommendation { get; internal set; }
    }
}