//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameRPG
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artefacts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artefacts()
        {
            this.Features = new HashSet<Features>();
        }
    
        public int ArtefactID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
    
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Features> Features { get; set; }
    }
}