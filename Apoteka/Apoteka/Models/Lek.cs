//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apoteka.Models
{
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.Collections.Generic;
    
    public partial class Lek
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Molimo unesite naziv!"), MinLength(3),MaxLength(20)]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Molimo unesite proizvodjaca!"), MinLength(10), MaxLength(50)]
        public string Proizvodjac { get; set; }
        [Required(ErrorMessage = "Molimo vas unesite uputstvo!"), MinLength(20), MaxLength(500)]
        public string Uputstvo { get; set; }
    }
}