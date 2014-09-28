using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Portfolio.Models
{
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForm
    {
    }

    public class ContactFormValidation
    {
        [Required]
        public string ContactFirstName { get; set; }

        [Required]
        public string ContactLastName { get; set; }
        
        [Required]
        public string ContactEmail { get; set; }
        
        [Required]
        public string ContactPhone { get; set; }
        
        [Required]
        public string ContactComment { get; set; }

    }
}