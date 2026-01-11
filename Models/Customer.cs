using System.ComponentModel.DataAnnotations;

namespace ecommercesite.Models
{
    public class Customer
    {
        [Key]
        
        public string CustId { get; set; }
        
        public string CustName{ get; set; }
        public string CustAddress { get; set; }

    }
}
