using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VoiceProject.Data.Contracts;
using VoiceProject.Data.Entities;

namespace VoiceProject.Data.Services.EF
{
    public class SurveyDataAccessService : ISurveyDataAccessService
    {
        private readonly VPDBContext _vPDBContext;
        public SurveyDataAccessService(VPDBContext vPDBContext)
        {
            _vPDBContext = vPDBContext;
        }

        public async Task<Survey> GetSurveyBySurveyId(int surveyId)
        {
            var survey = await _vPDBContext.Surveys.Include(s => s.SurveyQuestions).Where(s => s.Id == 1).FirstOrDefaultAsync();
            _vPDBContext.SurveyQuestions.Include(qa => qa.Question).ToList();
            _vPDBContext.QuestionAnswers.Include(qa => qa.Answer).ToList();
            return survey;
        }
    }
}
