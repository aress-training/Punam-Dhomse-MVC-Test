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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    #region "User Details"
    public partial class UserDetail
    { 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDetail()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public short User_Id { get; set; }
        public short UserType_Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        [RegularExpression("^([a-zA-Z]{2,})$", ErrorMessage = "Name contains only alphabets")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [RegularExpression(@"^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$", ErrorMessage = "Email address should be in the format abc@test.com")]
        [RemoteClientServer("IsEmailAvailable", "Authentication", ErrorMessage = "Email already in use.")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }


        [Required(ErrorMessage = "Password cannot be empty")]
        [DataType(DataType.Password, ErrorMessage = "Invalid password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).{8,16}$", ErrorMessage = "Password contains one special character, one uppercase, one lowercase, minimum 8 and maximum 16 characters")]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual UserTypeTable UserType { get; set; }
    }
    #endregion
}
