using System.Collections.Generic;

namespace VoiceProject.Data.Entities 
{
    public class Survey : VoiceProjectEntity
    {
        public string Name { get; set; }
        public ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
