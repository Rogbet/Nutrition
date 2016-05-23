using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Nutrition.Models;
using System;
using System.Collections.Generic;

namespace Nutrition.Controllers.api
{
    [Authorize]
    public class PatientsController : ApiController
    {
        private NutritionDBContext db = new NutritionDBContext();

        // GET: api/Patients
        public List<Patient> GetPatients()
        {
            var userID = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            var patients =  db.Patients.Where(p => p.Active == true && 
                                          p.CreatedByUserID == userID).AsEnumerable();

            return patients.ToList();
        }

        // GET: api/Patients/5
        [ResponseType(typeof(Patient))]
        public IHttpActionResult GetPatient(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        // PUT: api/Patients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPatient(int id, Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patient.PatientID)
            {
                return BadRequest();
            }
            
            db.Entry(patient).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Patients
        [ResponseType(typeof(Patient))]
        public IHttpActionResult PostPatient(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            patient.Active = true;
            patient.BirthDate = patient.BirthDate.Date;
            patient.CreatedDate = DateTime.Now;
            patient.CreatedByUserID = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;

            db.Patients.Add(patient);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
            return CreatedAtRoute("DefaultApi", new { id = patient.PatientID }, patient);
        }

        // DELETE: api/Patients/5
        [ResponseType(typeof(Patient))]
        public IHttpActionResult DeletePatient(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            //db.Patients.Remove(patient);
            //Logical Remove
            patient.Active = false;
            db.SaveChanges();

            return Ok(patient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientExists(int id)
        {
            return db.Patients.Count(e => e.PatientID == id) > 0;
        }
    }
}