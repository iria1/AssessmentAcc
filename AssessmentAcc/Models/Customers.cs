using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AssessmentAcc.CustomValidation;

namespace AssessmentAcc.Models
{
    public class Customers
    {
        public long Id { get; set; }

        [Display(Name = "Tipe Customer")]
        [Required]
        public string TipeCustomer { get; set; }

        [Required]
        public string Nama { get; set; }

        [Display(Name = "Nomor Telfon")]
        [Required]
        [CustomPhoneNoValidation(ErrorMessage = "Please enter a valid phone number")]
        public string NomorTelp { get; set; }

        [Required]
        public string Alamat { get; set; }

        [Display(Name = "Nomor Rekening")]
        [Required]
        public string NomorRekening { get; set; }
    }
}
