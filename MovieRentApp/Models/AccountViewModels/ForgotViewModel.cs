﻿using System.ComponentModel.DataAnnotations;

namespace MovieRentApp.Models.AccountViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}