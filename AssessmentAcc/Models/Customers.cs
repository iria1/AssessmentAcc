using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAcc.Models
{
    public class Customers
    {
        public long Id { get; set; }

        [Display(Name = "Tipe Customer")]
        public string TipeCustomer { get; set; }

        public string Nama { get; set; }

        [Display(Name = "Nomor Telfon")]
        [Required(ErrorMessage = "Please enter a valid phone number")]
        public string NomorTelp { get; set; }

        public string Alamat { get; set; }

        [Display(Name = "Nomor Rekening")]
        public string NomorRekening { get; set; }
    }
}
