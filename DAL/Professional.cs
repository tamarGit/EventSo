//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professional()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int ProfessionalCode { get; set; }
        public string ProfessionalName { get; set; }
        public int ProfessionalTypeCode { get; set; }
        public string ProfessionalPhone { get; set; }
        public int SeveralTimesInvited { get; set; }
        public string LivingArea { get; set; }
        public int TotalRatings { get; set; }
    
        public virtual ProfessionalType ProfessionalType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
