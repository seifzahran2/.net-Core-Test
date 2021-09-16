using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense Name")]
        [Required(ErrorMessage ="Enter Expense Name !")]
        public string ExpenseName { get; set; }
        
        [Range(1,int.MaxValue,ErrorMessage ="Enter Positive Number !")]
        [Required(ErrorMessage = "Enter Expense Amount !")]
        public int Amount { get; set; }
        
    }
}
