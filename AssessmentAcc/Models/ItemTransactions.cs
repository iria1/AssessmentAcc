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
        public long TransaksiId { get; set; }

        public int Jumlah { get; set; }

        public string Nama { get; set; }

        public string Satuan { get; set; }
    }
}
