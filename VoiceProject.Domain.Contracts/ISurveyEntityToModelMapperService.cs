using System.Threading.Tasks;
using VoiceProject.Domain.Models;

namespace VoiceProject.Domain.Contracts
{
    public interface ISurveyEntityToModelMapperService
    {
        Task<Survey> Map(Data.Entities.Survey survey);
    }
}
