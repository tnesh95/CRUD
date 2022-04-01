using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Customer name is required")]
        [DisplayName("Customer Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "* Name must be between 1 and 50 character in length.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Customer contact number is required")]
        [DisplayName("Customer Contact Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ContactNumber { get; set; }

        [DisplayName("Customer Age")]
        [Required(ErrorMessage = "Customer age is required")]
        public int Age { get; set; }

        [DisplayName("Customer Location")]
        [Required(ErrorMessage = "Customer location is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "* Location must be between 1 and 100 character in length.")]
        public string Location { get; set; }

        [DisplayName("Remarks")]
        [Required(ErrorMessage = "Remarks age is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "* Remarks must be between 1 and 100 character in length.")]

        public string Remarks { get; set; }
    }

    public class EFDatabaseCRUD : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
    }
}