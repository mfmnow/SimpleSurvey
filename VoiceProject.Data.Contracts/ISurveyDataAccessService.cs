using System.Threading.Tasks;
using VoiceProject.Data.Entities;

namespace VoiceProject.Data.Contracts
{
    public interface ISurveyDataAccessService
    {
        Task<Survey> GetSurveyBySurveyId(int surveyId);
    }
}
