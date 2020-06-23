using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using InterviewProject.Models;
using InterviewProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : Controller
    {
        private readonly IInterviewService service;
        public InterviewController(IInterviewService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Interview>>> Get()
        {
            return await service.GetAllInterviews();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Interview>> GetOne(int id)
        {
            return await service.ChooseInterviewByTechnology(id);
        }

        [HttpPut]
        public async Task<ActionResult<Interview>> Update(Interview entity)
        {
            return await service.UpdateInterview(entity);
        }

        [HttpPost]
        public async Task<ActionResult<Interview>> Create(Interview entity)
        {
            return await service.CreateInterview(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Interview>> Delete(int id)
        {
            return await service.DeleteInterview(id);
        }

    }
}
