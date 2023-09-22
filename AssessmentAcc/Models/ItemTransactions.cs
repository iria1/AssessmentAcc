using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssessmentAcc.Models
{
    public class ItemTransactions
    {
        public long Id { get; set; }

        [Display(Name = "ID Transaksi")]
        [Required]
        public long TransaksiId { get; set; }

        [Required]
        public int Jumlah { get; set; }

        [Required]
        public string Nama { get; set; }

        [Required]
        public string Satuan { get; set; }
    }
}
