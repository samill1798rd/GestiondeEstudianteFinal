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
    
    public partial class Estudiante
    {
        public int Id_Estudiantes { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public byte[] Imagen { get; set; }
        public int? Matricula { get; set; }
        public int? Nacionalidad_id { get; set; }
        public int? Carrera { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public bool? IsActive { get; set; }
    
        public virtual nacionalidad nacionalidad { get; set; }
    }
}
