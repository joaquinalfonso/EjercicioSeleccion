//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transcripcion
    {
        public int Id { get; set; }
        public System.DateTime FechaHoraRecepcion { get; set; }
        public string LoginUsuario { get; set; }
        public string NombreArchivo { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaHoraTranscripcion { get; set; }
        public string MensajeError { get; set; }
    }
}