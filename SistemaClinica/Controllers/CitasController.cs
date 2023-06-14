using SistemaClinica.Models;
using SistemaClinica.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SistemaClinica.Controllers
{
    public class CitasController : Controller
    {
        private ClinicaContext db = new ClinicaContext();
        // GET: Citas
        public ActionResult Index()
        {
            return View(db.Citas.ToList());
        }

        // GET: Citas/Create
        public ActionResult Create()
        {
            ViewBag.dropdownPacientes = new SelectList(db.Pacientes.Select(paciente => new { value = paciente.IdPaciente, text = paciente.Nombre + " " + paciente.Apellido }), "value", "text");

            ViewBag.dropdownMedicos = new SelectList(db.Medicos.Select(medico => new { value = medico.IdMedico, text = medico.Nombre + " " + medico.Apellido }), "value", "text");

            return View(new Cita());
        }

        // POST: Citas/Create
        [HttpPost]
        public ActionResult Create(Cita newCita)
        {
            newCita.Estado = "Pendiente";
            try
            {
                db.Citas.Add(newCita);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("<h1>La acción no se pudo realizar! Error:" + ex.Message + "</h1>");
            }
        }

        public ActionResult CompletarCita(int idCita)
        {
            ViewBag.idCita = idCita;
            CitaConsultaViewData vm = new CitaConsultaViewData();
            vm.Cita = db.Citas.Find(idCita);
            vm.Consulta = new Consulta();
            vm.Consulta.IdCita = idCita;
            return View(vm);
        }

        public ActionResult CancelarCita(int idCita)
        {
            try
            {
                db.Citas.Find(idCita).Estado = "Cancelada";
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("<h1>La acción no se pudo realizar! Error:" + ex.Message + "</h1>");
            }
        }
    }
}