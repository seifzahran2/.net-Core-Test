using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Borrower Name !")]
        public string Borrower { get; set; }
        [Required(ErrorMessage = "Enter Lender Name !")]
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        [Required(ErrorMessage = "Enter Item Name !")]
        public string ItemName { get; set; }
    }
}
