using System.Threading.Tasks;
using VoiceProject.Data.Contracts;
using VoiceProject.Domain.Contracts;
using VoiceProject.Domain.Models;

namespace VoiceProject.Domain.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyDataAccessService _surveyDataAccessService;
        private readonly ISurveyEntityToModelMapperService _surveyEntityToModelMapperService;
        public SurveyService(ISurveyDataAccessService surveyDataAccessService, 
            ISurveyEntityToModelMapperService surveyEntityToModelMapperService)
        {
            _surveyDataAccessService = surveyDataAccessService;
            _surveyEntityToModelMapperService = surveyEntityToModelMapperService;
        }

        public async Task<Survey> GetSurveyBySurveyId(int surveyId)
        {
            var surveyEntity = await _surveyDataAccessService.GetSurveyBySurveyId(surveyId);
            return await _surveyEntityToModelMapperService.Map(surveyEntity);
        }
    }
}
