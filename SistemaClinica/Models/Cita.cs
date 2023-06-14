namespace SistemaClinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cita()
        {
            Consultas = new HashSet<Consulta>();
        }

        [Key]
        public int IdCita { get; set; }

        public int? IdPaciente { get; set; }

        public int? IdMedico { get; set; }

        public DateTime? FechaHora { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public virtual Medico Medico { get; set; }

        public virtual Paciente Paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
