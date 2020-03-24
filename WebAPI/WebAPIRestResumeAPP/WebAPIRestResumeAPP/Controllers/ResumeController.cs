using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIRestResumeAPP.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebAPIRestResumeAPP.Controllers
{
    public class ResumeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult AddEmoloyee(CandidateResume candidateResume)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Models.Candidate cm = new Candidate();
            cm.CandidateResumes.Add(candidateResume);
            cm.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = candidateResume.CandidateId }, candidateResume);
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeeSummary(string id) {
            CandidateResume Resume = new CandidateResume();
            HttpResponseMessage response;

            if (string.IsNullOrEmpty(id))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "No Id Provided.");
                return response;
            }
            using (Models.Candidate cm = new  Candidate())
            {
                Resume = cm.CandidateResumes.FirstOrDefault(a => a.CandidateId == id);

                response = Request.CreateResponse(HttpStatusCode.OK, Resume.JobSummary);
                return response;
            }
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeeName(string id)
        {
            CandidateResume Resume = new CandidateResume();
            HttpResponseMessage response;

            if (string.IsNullOrEmpty(id))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "No Id Provided.");
                return response;
            }
            using (Models.Candidate cm = new Candidate())
            {
                Resume = cm.CandidateResumes.FirstOrDefault(a => a.CandidateId == id);

                response = Request.CreateResponse(HttpStatusCode.OK, Resume.Name);
                return response;
            }
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeeEmailID(string id)
        {
            CandidateResume Resume = new CandidateResume();
            HttpResponseMessage response;

            if (string.IsNullOrEmpty(id))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "No Id Provided.");
                return response;
            }
            using (Models.Candidate cm = new Candidate())
            {
                Resume = cm.CandidateResumes.FirstOrDefault(a => a.CandidateId == id);

                response = Request.CreateResponse(HttpStatusCode.OK, Resume.EmailId);
                return response;
            }
        }

        [HttpGet]
        public HttpResponseMessage GetEmployeePhone(string id)
        {
            CandidateResume Resume = new CandidateResume();
            HttpResponseMessage response;

            if (string.IsNullOrEmpty(id))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "No Id Provided.");
                return response;
            }
            using (Models.Candidate cm = new Candidate())
            {
                Resume = cm.CandidateResumes.FirstOrDefault(a => a.CandidateId == id);

                response = Request.CreateResponse(HttpStatusCode.OK, Resume.Phone);
                return response;
            }
        }


        [HttpGet]
        public HttpResponseMessage GetEmployeeJobTitle(string id)
        {
            CandidateResume Resume = new CandidateResume();
            HttpResponseMessage response;

            if (string.IsNullOrEmpty(id))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "No Id Provided.");
                return response;
            }
            using (Models.Candidate cm = new Candidate())
            {
                Resume = cm.CandidateResumes.FirstOrDefault(a => a.CandidateId == id);

                response = Request.CreateResponse(HttpStatusCode.OK, Resume.JobTitle);
                return response;
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmp(string id)
        {
            Models.Candidate cm = new Candidate();
            CandidateResume candidateResume = cm.CandidateResumes.Find(id);
            if(candidateResume == null)
            {
                return NotFound();
            }
            cm.CandidateResumes.Remove(candidateResume);
            cm.SaveChanges();
            return Ok(candidateResume);
        }

        [HttpPut]
        public IHttpActionResult UpdateResume(string id, CandidateResume candidateResume)
        {
            if(!ModelState .IsValid)
            {
                return BadRequest(ModelState);
            }
            if(id != candidateResume.CandidateId)
            {
                return BadRequest("ID does not match.");
            }

            Models.Candidate cm = new Candidate();
            cm.Entry(candidateResume).State = EntityState.Modified;

            try
            {
                cm.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
            
        }

    }
}