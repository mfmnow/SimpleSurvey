using Microsoft.EntityFrameworkCore;
using VoiceProject.Data.Entities;

namespace VoiceProject.Data.Services.EF
{
    public class VPDBContext : DbContext
    {
        public VPDBContext(DbContextOptions<VPDBContext> options) : base(options)
        {

        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("Question");
            modelBuilder.Entity<Answer>().ToTable("Answer");
            modelBuilder.Entity<QuestionAnswer>().ToTable("QuestionAnswer");
            modelBuilder.Entity<Survey>().ToTable("Survey");
            modelBuilder.Entity<SurveyQuestion>().ToTable("SurveyQuestion");
        }
    }
}

