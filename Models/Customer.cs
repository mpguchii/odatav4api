using System.ComponentModel.DataAnnotations;

namespace ODataNetCore.Models
{
    public class Customer
    {
        [Key]
        public long CUSTOMER_ID { get; set; }
        public string FANTASY_NAME { get; set; }
        public string BRAND_NAME { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string NEIGHBORHOOD { get; set; }
        public string STREET { get; set; }
        public string ZIPCODE { get; set; }
        public string CONTACT_FIRSTNAME { get; set; }
        public string CONTACT_LASTNAME { get; set; }
        public string PHONE { get; set; }
        public long TOTAL_ORDERS { get; set; }
        public int OPEN_ORDERS { get; set; }
        public int CLOSED_ORDERS { get; set; }
        public int ZKR3_ORDERS { get; set; }
        public int ZKR5_ORDERS { get; set; }
        public int ZKR6_ORDERS { get; set; }
        public int OPEN_ZKR3 { get; set; }
        public int OPEN_ZKR5 { get; set; }
        public int OPEN_ZKR6 { get; set; }
        public int CLOSED_ZKR3 { get; set; }
        public int CLOSED_ZKR5 { get; set; }
        public int CLOSED_ZKR6 { get; set; }
        public long LAST_ORDER_ID { get; set; }
        public DateTime LAST_ORDER_DATE_OPEN { get; set; }
        public int LAST_QTD_CO2_BARREL { get; set; }
        public int LAST_QTD_BARREL_CHOPP30 { get; set; }
        public int LAST_QTD_BARREL_CHOPP50 { get; set; }
    }
}