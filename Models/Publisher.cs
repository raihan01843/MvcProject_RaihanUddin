//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject_Raihan.Models
{
    using MvcProject_Raihan.CustomValidation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Publisher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publisher()
        {
            this.BookDetails = new HashSet<BookDetail>();
        }
    
        public int PublisherId { get; set; }
        [Required(ErrorMessage = "You Can't Leave it Blank")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You Can't Leave it Blank")]
        [Display(Name = "Cell Phone No")]
        public string CellPhoneNo { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [CustomHireDate(ErrorMessage = "Hire Date must be less than or equal to Today's Date")]
        public System.DateTime PublishDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookDetail> BookDetails { get; set; }
    }
}
