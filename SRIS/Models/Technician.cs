using System.Collections.Generic;

namespace SRIS.Models
{
    public class Technician
    {
        public int Tech_id { get; set; }
        public string TechName { get; set; }
        public string TechPosition { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TechnicianService> TechnicianService { get; internal set; }
    }
}