using System.Collections.Generic;

namespace VoiceProject.Data.Entities
{
    public class Question : VoiceProjectEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Order { get; set; }
        public int MinimumValueAccepted { get; set; }
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
