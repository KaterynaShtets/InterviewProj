using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using CoreModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : Controller
    {
        private readonly IInterviewService _service;
        public InterviewController(IInterviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Interview>>> Get()
        {
            return await _service.GetAllInterviews();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Interview>> GetOne(int id)
        {
            return await _service.ChooseInterviewByTechnology(id);
        }

        [HttpPut]
        public async Task<ActionResult<Interview>> Update(Interview entity)
        {
            return await _service.UpdateInterview(entity);
        }

        [HttpPost]
        public async Task<ActionResult<Interview>> Create(Interview entity)
        {
            return await _service.CreateInterview(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Interview>> Delete(int id)
        {
            return await _service.DeleteInterview(id);
        }

    }
}
