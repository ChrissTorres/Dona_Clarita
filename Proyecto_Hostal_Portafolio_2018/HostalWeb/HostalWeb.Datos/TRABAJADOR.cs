//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRABAJADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRABAJADOR()
        {
            this.EMPRESA = new HashSet<EMPRESA>();
            this.HUESPED = new HashSet<HUESPED>();
        }
    
        public int ID { get; set; }
        public int RUT { get; set; }
        public string DV { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int EMPRESA_ID { get; set; }
        public Nullable<int> USUARIO_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HUESPED> HUESPED { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
