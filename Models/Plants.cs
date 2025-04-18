using System.ComponentModel.DataAnnotations;

namespace ODataNetCore.Models
{
    public class Plant
    {
        [Key]
        public string PLANT { get; set; }
    }
}