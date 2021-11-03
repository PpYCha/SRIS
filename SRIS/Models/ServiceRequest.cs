using System;
using System.Collections.Generic;

namespace SRIS.Models
{
    public class ServiceRequest
    {
        public int Sr_id { get; set; }
        public string TypeOfServiceProvided { get; set; }
        public string TypeOfServiceProvided_Description { get; set; }
        public string RequestedBy { get; set; }
        public DateTime? DateRequested { get; set; }
        public string FaultDiagnosis { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string Status { get; set; }
        public string DateEntered { get; set; }
        public ICollection<TechnicianService> TechnicianService { get; internal set; }
        public string OfficeDepartmentSr { get; set; }
    }
}