//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea_3.Dominio.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class subTipoObjeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subTipoObjeto()
        {
            this.objeto = new HashSet<objeto>();
        }
    
        public int idSubTipo { get; set; }
        public string subTipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objeto> objeto { get; set; }
        public virtual tipoObjeto tipoObjeto { get; set; }
    }
}