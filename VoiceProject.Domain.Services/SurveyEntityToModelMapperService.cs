using System.Linq;
using System.Threading.Tasks;
using VoiceProject.Domain.Contracts;
using VoiceProject.Domain.Models;

namespace VoiceProject.Domain.Services
{
    public class SurveyEntityToModelMapperService : ISurveyEntityToModelMapperService
    {
        public Task<Models.Survey> Map(Data.Entities.Survey survey)
        {
            var surveyModel = new Models.Survey()
            {
                Id = survey.Id,
                Name = survey.Name,
                Questions = survey.SurveyQuestions.Select(sq=> new Question(){
                        Id = sq.Question.Id,
                        Body = sq.Question.Body,
                        MinimumValueAccepted = sq.Question.MinimumValueAccepted,
                        Order = sq.Question.Order,
                        Title = sq.Question.Title,
                        Answers = sq.Question.QuestionAnswers.Select(qa=> new Answer() {
                                Id = qa.Answer.Id,
                                Body = qa.Answer.Body,
                                Value = qa.Answer.Value
                            }                            
                         ).ToList()
                }).ToList()
            };
            return Task.FromResult(surveyModel);
        }
    }
}
