using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceProject.Data.Entities
{
    public class SurveyQuestion : VoiceProjectEntity
    {
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [ForeignKey("Survey")]
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}
