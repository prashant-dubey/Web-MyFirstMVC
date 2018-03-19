//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMVC.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSUser()
        {
            this.SYSUserProfiles = new HashSet<SYSUserProfile>();
            this.SYSUserRoles = new HashSet<SYSUserRole>();
        }
    
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordEncryptedText { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserProfile> SYSUserProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserRole> SYSUserRoles { get; set; }
    }
}
