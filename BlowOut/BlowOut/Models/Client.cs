using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required(ErrorMessage="A first name is required")]
        [Display(Name="First Name")]
        [StringLength(30, ErrorMessage="Name is too long. Please shorten to 30 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="A last name is required")]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Name is too long. Please shorten to 30 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage="An address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage="A city is required")]
        public string City { get; set; }

        [Required(ErrorMessage="A state is required")]
        [RegularExpression(@"^(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))$",
            ErrorMessage="Please enter a 2 character state code (e.g. UT for Utah)")]
        public string State { get; set; }

        [Required(ErrorMessage="A ZIP Code is required")]
        [Display(Name = "ZIP Code")]
        [RegularExpression(@"^\d{5}([\-]\d{4})?$", ErrorMessage="Please enter a valid ZIP Code.")]
        public string ZIP { get; set; }

        [Required(ErrorMessage="An email is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", 
        ErrorMessage = "Please enter correct Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage="A phone number is required")]
        [StringLength(13, MinimumLength=10, ErrorMessage="Phone number must have at least 10 digits. ")]
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "PhoneNumber should contain only numbers, and no extensions")]
        public string Phone { get; set; }

        public int? InstrumentID { get; set; }
    }
}