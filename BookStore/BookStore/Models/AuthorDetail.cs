//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.Models
{
    using BookStore.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class AuthorDetail
    {
        #region "Author Details"
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuthorDetail()
        {
            this.BookDetails = new HashSet<BookDetail>();
        }

        public short Author_Id { get; set; }

        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Name cannot be empty")]
        [RegularExpression("^([a-zA-Z\\s]{2,})$", ErrorMessage = "Name contains only alphabets")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [RegularExpression(@"^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$", ErrorMessage = "Email address should be in the format abc@test.com")]
        [RemoteClientServer("IsEmailAvailable", "Authentication", ErrorMessage = "Email already in use.")]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookDetail> BookDetails { get; set; }
    }
    #endregion
}
