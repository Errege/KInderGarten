//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KInderGarten
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHILD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHILD()
        {
            this.MANAGER = new HashSet<MANAGER>();
            this.SECRETARY = new HashSet<SECRETARY>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public int ID_GROUP { get; set; }
        public byte[] IMAGE { get; set; }
    
        public virtual GROUP GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANAGER> MANAGER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECRETARY> SECRETARY { get; set; }
    }
}
