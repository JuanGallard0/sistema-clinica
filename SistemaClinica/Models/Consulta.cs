namespace SistemaClinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }

        public int? IdPaciente { get; set; }

        public int? IdMedico { get; set; }

        public int? IdCita { get; set; }

        [StringLength(512)]
        public string Diagnostico { get; set; }

        [StringLength(512)]
        public string Tratamiento { get; set; }

        public virtual Cita Cita { get; set; }

        public virtual Medico Medico { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
