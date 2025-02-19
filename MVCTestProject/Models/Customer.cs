﻿using System.ComponentModel.DataAnnotations;

namespace MVCTestProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Delivery City")]
        public string DeliveryCity { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Postal code")]
        public string DeliveryZip { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
