using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClinicaMedicare.Models;

namespace ClinicaMedicare.Controllers{
    public class PacienteController : Controller{
        static List<Paciente> ListaPaciente = new List<Paciente>();
        public static int Identificador = 1;
        Paciente paciente = new Paciente();

        public IActionResult Index() {
            List<Paciente> listaOrdenada = ListaPaciente.OrderBy(p => p.id).ToList();
            var model = listaOrdenada;
            return View("Index", model);
        }

        public IActionResult Create(){
            ViewBag.Iden = Identificador;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Paciente paciente){
            if (ModelState.IsValid){
                ListaPaciente.Add(paciente);
                Identificador++;
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Iden = Identificador;
            return View();
        }

        public void ObtenerDatos(int id) {
            int pos = ListaPaciente.FindIndex(p => p.id == id);
            paciente.id = ListaPaciente[pos].id;
            paciente.Nombre = ListaPaciente[pos].Nombre;
            paciente.Edad = ListaPaciente[pos].Edad;
            paciente.Enfermedad = ListaPaciente[pos].Enfermedad;
        }

        public IActionResult Details(int id){
            ObtenerDatos(id);
            return View(paciente);
        }

        public IActionResult Edit(int id){
            ObtenerDatos(id);
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Edit(int id, Models.Paciente paciente) {
            if (ModelState.IsValid){
                ObtenerDatos(id);
                int pos = ListaPaciente.FindIndex(p => p.id == id);
                ListaPaciente.RemoveAt(pos);
                ListaPaciente.Add(paciente);
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        } 

        public IActionResult Delete(int id){
            ObtenerDatos(id);
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Delete(int id, Models.Paciente paciente) {
            ObtenerDatos(id);
            int pos = ListaPaciente.FindIndex(p => p.id == id);
            ListaPaciente.RemoveAt(pos);
            return RedirectToAction(nameof(Index));
        }
    }
}