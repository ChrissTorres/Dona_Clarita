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
    
    public partial class SERVICIO_ODEN_COMPRA
    {
        public int ID { get; set; }
        public int SERVICIO_ID { get; set; }
        public int ORDEN_COMPRA_ID { get; set; }
        public int VALOR { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ORDEN_COMPRA ORDEN_COMPRA { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}
