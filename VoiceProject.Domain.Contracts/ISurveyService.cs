using System.Threading.Tasks;
using VoiceProject.Domain.Models;

namespace VoiceProject.Domain.Contracts
{
    public interface ISurveyService
    {
        Task<Survey> GetSurveyBySurveyId(int surveyId);
    }
}
