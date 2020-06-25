using BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreModel.Models;
using DataAccessLayer.Repositories;

namespace BusinessLogic.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly InterviewRepository _repository;

        public InterviewService(InterviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Interview>> GetAllInterviews()
        {
            return await _repository.GetAll();
        }

        public async Task<Interview> GetInterview(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<Interview> UpdateInterview(Interview entity)
        {
            return await _repository.Update(entity);
        }

        public async Task<Interview> CreateInterview(Interview entity)
        {
            return await _repository.Add(entity);
        }

        public async Task<Interview> DeleteInterview(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<Interview> ChooseInterviewByTechnology(int technologyId)
        {
            var interviews = await _repository.GetAll();
            return interviews.FirstOrDefault(p => p.TechnologyId.Equals(technologyId));
        }
    }
}