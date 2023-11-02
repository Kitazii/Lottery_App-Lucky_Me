using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuckyMeMVC.Models
{
    public class LotteryNumber
    {
        [Required]
        [Display(Name = "Number 1")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_1 { get; set; }

        [Required]
        [Display(Name = "Number 2")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_2 { get; set; }

        [Required]
        [Display(Name = "Number 3")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_3 { get; set; }

        [Required]
        [Display(Name = "Number 4")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_4 { get; set; }

        [Required]
        [Display(Name = "Number 5")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_5 { get; set; }

        [Required]
        [Display(Name = "Number 6")]
        [Range(1, 59, ErrorMessage = "Please enter a positive whole number between 1 and 59")]
        public int Number_6 { get; set; }

    }
}