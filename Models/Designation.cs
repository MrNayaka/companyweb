//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace companyweb1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Designation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Department Name is required")]
        [Display(Name ="Designation Name")]
        public string Name { get; set; }
    }
}