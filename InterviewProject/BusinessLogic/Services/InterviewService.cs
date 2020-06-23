using BusinessLogic.Interfaces;
using InterviewProject.Interfaces;
using InterviewProject.Models;
using InterviewProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly InterviewRepository repository;

        public InterviewService(InterviewRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<Interview>> GetAllInterviews()
        {
            return await repository.GetAll();
        }

        public async Task<Interview> GetInterview(int id)
        {
            return await repository.Get(id);
        }

        public async Task<Interview> UpdateInterview(Interview entity)
        {
            return await repository.Update(entity);
        }

        public async Task<Interview> CreateInterview(Interview entity)
        {
            return await repository.Add(entity);
        }

        public async Task<Interview> DeleteInterview(int id)
        {
            return await repository.Delete(id);
        }

        public async Task<Interview> ChooseInterviewByTechnology(int technologyId)
        {
            List<Interview> interviews = await repository.GetAll();
            return interviews.Where(p => p.TechnologyId.Equals(technologyId)).FirstOrDefault();
        }
    }
}