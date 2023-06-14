namespace SistemaClinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medico()
        {
            Citas = new HashSet<Cita>();
            Consultas = new HashSet<Consulta>();
        }

        [Key]
        public int IdMedico { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Cargo { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
