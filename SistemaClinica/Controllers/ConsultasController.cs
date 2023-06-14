using SistemaClinica.Models;
using SistemaClinica.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SistemaClinica.Controllers
{
    public class ConsultasController : Controller
    {
        private ClinicaContext db = new ClinicaContext();

        public ActionResult Index()
        {
            return View(db.Consultas.ToList());
        }

        [HttpPost]
        public ActionResult Create(CitaConsultaViewData vm, int idCita)
        {
            try
            {
                Cita CitaToEdit = db.Citas.Find(idCita);
                CitaToEdit.Estado = "Completada";
                vm.Consulta.IdCita = idCita;
                vm.Consulta.IdPaciente = CitaToEdit.IdPaciente;
                vm.Consulta.IdMedico = CitaToEdit.IdMedico;
                db.Consultas.Add(vm.Consulta);
                db.SaveChanges();
                return RedirectToAction("Index", new { controller = "Citas", area = string.Empty });
            }
            catch (Exception ex)
            {
                return Content("<h1>La acción no se pudo realizar! Error:" + ex.Message + "</h1>");
            }
        }
    }
}