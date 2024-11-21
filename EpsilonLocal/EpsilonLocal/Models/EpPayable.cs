﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpsilonLocal.Models
{
    public class EpPayable
    {

        public int Id { get; set; }

        public bool IsDeleted { get; set;}
        public string Contractor { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public string Month { get; set; }
    }
}
