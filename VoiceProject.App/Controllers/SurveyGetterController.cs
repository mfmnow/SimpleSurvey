using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VoiceProject.App.Models;
using VoiceProject.Domain.Contracts;
using VoiceProject.Domain.Models;

namespace VoiceProject.App.Controllers
{
    [Route("api/survey")]
    [ApiController]
    public class SurveyGetterController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        private readonly ILogger _logger;
        public SurveyGetterController(ISurveyService surveyService, ILogger<SurveyGetterController> logger)
        {
            _surveyService = surveyService;
            _logger = logger;
        }

        [HttpGet]
        [Route("get/{surveyId}")]
        public async Task<APIRequestResult<Survey>> GetSurvey(int surveyId)
        {
            try
            {
                return new APIRequestResult<Survey>()
                {
                    Success = true,
                    Message = "",
                    Data = await _surveyService.GetSurveyBySurveyId(surveyId)
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SurveyGetterController.GetSurvey throw an exception");
                return new APIRequestResult<Survey>()
                {
                    ServerError = true,
                    Success = false,
                    ErrorMessage = "Server Error occured"
                };
            }
        }
    }
}