using System;
using System.Collections.Generic;

namespace SRIS.Models
{
    public class ItemReplacement
    {
        public int Ir_id { get; internal set; }
        public string RequestingOffice { get; set; }
        public DateTime? DateReplace { get; set; }
        public string PropertyNo { get; set; }
        public string TypeOfUnit { get; set; }
        public string UnitReleasedTo { get; set; }
        public string PositionReleasedTo { get; set; }
        public string DateReleasedTo { get; set; }

        public ICollection<TechnicianService> TechnicianService { get; internal set; }
        public ICollection<Item> Item { get; internal set; }
    }
}