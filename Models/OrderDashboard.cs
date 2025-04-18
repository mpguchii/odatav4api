using System.ComponentModel.DataAnnotations;

namespace ODataNetCore.Models
{
    public class OrderDashboard
    {
        [Key]
        public string PERIOD { get; set; }
        public string PLANT { get; set; }
        public long TOTAL_ORDERS { get; set; }
        public int OPEN_ORDERS { get; set; }
        public int CLOSED_ORDERS { get; set; }
        public int OPEN_ZKR3 { get; set; }
        public int OPEN_ZKR5 { get; set; }
        public int OPEN_ZKR6 { get; set; }
        public int CLOSED_ZKR3 { get; set; }
        public int CLOSED_ZKR5 { get; set; }
        public int CLOSED_ZKR6 { get; set; }
        public int DIVERGENT_ORDERS { get; set; }

    }
}
