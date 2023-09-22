using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssessmentAcc.Models
{
    public class Transactions
    {
        public long Id { get; set; }

        [Display(Name = "Nomor Urut")]
        [Required]
        public string NomorUrut { get; set; }

        [Display(Name = "ID Customer")]
        [Required]
        public long CustomerId { get; set; }

        [Display(Name = "Tanggal Pemesanan")]
        [Required]
        public DateTime TanggalPemesanan { get; set; }

        [Display(Name = "Tanggal Pengiriman")]
        [Required]
        public DateTime TanggalPengiriman { get; set; }

        [Display(Name = "Term Of Payment")]
        [Required]
        public string TermOfPayment { get; set; }

        [Display(Name = "Jumlah Nominal")]
        [Required]
        public double JumlahNominal { get; set; }

        [Display(Name = "Status Approval")]
        [Required]
        public string StatusApproval { get; set; }
    }
}
