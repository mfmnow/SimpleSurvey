using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceProject.Data.Entities
{
    public class QuestionAnswer: VoiceProjectEntity
    {
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [ForeignKey("Answer")]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
