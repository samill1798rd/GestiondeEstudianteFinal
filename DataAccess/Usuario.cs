//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id_usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }
    }
}
