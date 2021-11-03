namespace SRIS.Models
{
    public class Item
    {
        public int I_id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public ItemReplacement ItemReplacement { get; internal set; }
        public int? Ir_id { get; internal set; }
    }
}