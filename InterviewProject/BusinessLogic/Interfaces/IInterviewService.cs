using System.Collections.Generic;
using System.Threading.Tasks;
using CoreModel.Models;

namespace BusinessLogic.Interfaces
{
    public interface IInterviewService
    {
        Task<List<Interview>> GetAllInterviews();
        Task<Interview> ChooseInterviewByTechnology(int technologyId);
        Task<Interview> GetInterview(int id);
        Task<Interview> CreateInterview(Interview entity);
        Task<Interview> UpdateInterview(Interview entity);
        Task<Interview> DeleteInterview(int id);
    }
}
