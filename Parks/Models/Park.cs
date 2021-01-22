namespace Parks.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        public string ParkName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        public string Status { get; set; }
        public string Website { get; set; }
    }
}
