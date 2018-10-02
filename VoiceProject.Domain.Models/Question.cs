using System.Collections.Generic;

namespace VoiceProject.Domain.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Order { get; set; }
        public int MinimumValueAccepted { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
