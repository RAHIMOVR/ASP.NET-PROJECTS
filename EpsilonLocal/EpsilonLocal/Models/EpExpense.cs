using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpsilonLocal.Models
{
    public class EpExpense
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal İncomingAmount { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExpenseAmount { get; set; }
        
        public string Person { get; set; }

        public string Date { get; set; }
        public string Month { get; set; } 
    }
}
