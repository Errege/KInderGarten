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
    
    public partial class GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GROUP()
        {
            this.CHILD = new HashSet<CHILD>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public int ID_CAREGIVER { get; set; }
    
        public virtual CAREGIVER CAREGIVER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHILD> CHILD { get; set; }
    }
}
