using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HMS.Contollers
{
    public class DoctorController : Controller 
    {
        private static List<Doctor> doctors = new List<Doctor>
        {
            new Doctor { Id = 1, Name = "Dr. Smith", Specialization ="Cardiology", 
            Phone = "123456789", Email = "smith@example.com" }
        };

        public IActionResult List() {
            return View(doctors);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor) {

            doctor.Id = doctors.Count + 1;
            doctors.Add(doctor);
            return RedirectToAction("List");
        }
        }
    }
