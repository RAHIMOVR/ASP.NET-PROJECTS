using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpsilonLocal.Models
{
    public class Opportunity
    {

        public int Id { get; set; }
        public string ProjectName { get; set; }

        public string Client { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Value { get; set; }

        public bool IsDeleted { get; set; }

        public string Probability { get; set; }

        public string ContactPerson { get; set; }

        public string Status { get; set; }

        public string Deadline { get; set; }

        public string ContractStatus { get; set; }

        public string ContractDate { get; set; }

        public string Comments { get; set; }




    }
}
