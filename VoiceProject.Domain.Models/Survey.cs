using System.Collections.Generic;

namespace VoiceProject.Domain.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
