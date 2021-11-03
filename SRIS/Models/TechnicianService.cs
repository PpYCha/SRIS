using System.ComponentModel.DataAnnotations.Schema;

namespace SRIS.Models
{
    public class TechnicianService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ts_id { get; set; }

        public ServiceRequest ServiceRequest { get; set; }
        public int? Sr_id { get; set; }

        public Technician Technician { get; set; }
        public int Tech_id { get; set; }

        public ItemReplacement ItemReplacement { get; internal set; }
        public int? Ir_id { get; internal set; }

        public bool ProvidedBy { get; set; }
    }
}