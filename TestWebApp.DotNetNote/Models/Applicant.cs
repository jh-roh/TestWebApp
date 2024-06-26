﻿using System.ComponentModel.DataAnnotations;

namespace TestWebApp.DotNetNote.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [Display(Name = "이름")]
        [Required(ErrorMessage = "이름을 입력하시오.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "이름은 1자 이상 25자 이하")]
        public string Name { get; set; }

        [Required]
        public string FatherName { get; set; }

        public string FatherDob { get; set; }

        [Required]
        public bool IsFatherMember { get; set; }

        [Required]

        public string MotherName { get; set; }  


        public string MotherDob { get; set; }
    }
}
