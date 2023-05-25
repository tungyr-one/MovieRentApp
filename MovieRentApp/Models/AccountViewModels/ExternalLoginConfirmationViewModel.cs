﻿using System.ComponentModel.DataAnnotations;

namespace MovieRentApp.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}