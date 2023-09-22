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
        public string NomorUrut { get; set; }

        [Display(Name = "ID Customer")]
        public long CustomerId { get; set; }

        [Display(Name = "Tanggal Pemesanan")]
        public DateTime TanggalPemesanan { get; set; }

        [Display(Name = "Tanggal Pengiriman")]
        public DateTime TanggalPengiriman { get; set; }

        [Display(Name = "Term Of Payment")]
        public string TermOfPayment { get; set; }

        [Display(Name = "Jumlah Nominal")]
        public double JumlahNominal { get; set; }

        [Display(Name = "Status Approval")]
        public string StatusApproval { get; set; }
    }
}
