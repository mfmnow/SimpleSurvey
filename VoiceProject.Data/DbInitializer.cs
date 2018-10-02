using System;
using System.Linq;
using VoiceProject.Data.Entities;

namespace VoiceProject.Data.Services.EF
{
    public static class DbInitializer
    {
        public static void Initialize(VPDBContext context)
        {
            context.Database.EnsureCreated();
            SeedData(context);
        }

        static void SeedData(VPDBContext context)
        {
            string createBy = "SYSTEM";
            if (context.Questions.Count() == 0)
            {
                context.Questions.AddRange(
                    new Question
                    {
                        Title = "HTML",
                        Body = "Level of Skill in HTML",
                        Order = 1,
                        MinimumValueAccepted = 4,
                        CreatedBy = createBy,
                        CreatedDate = DateTime.Now
                    },
                    new Question
                    {
                        Title = "C#",
                        Body = "Level of Skill in C#",
                        Order = 2,
                        MinimumValueAccepted = 3,
                        CreatedBy = createBy,
                        CreatedDate = DateTime.Now
                    },
                    new Question
                    {
                        Title = "Angular",
                        Body = "Level of Skill in Angular",
                        Order = 3,
                        MinimumValueAccepted = 2,
                        CreatedBy = createBy,
                        CreatedDate = DateTime.Now
                    }
                );
                context.SaveChanges();

                for (var i = 1; i < 6; i++)
                {
                    context.Answers.Add(
                        new Answer()
                        {
                            Body = $"Level {i}",
                            Value = i,
                            CreatedBy = createBy,
                            CreatedDate = DateTime.Now
                        }
                    );
                }
                context.SaveChanges();

                foreach (Question question in context.Questions)
                {
                    foreach (Answer answer in context.Answers)
                    {
                        context.QuestionAnswers.Add(
                            new QuestionAnswer()
                            {
                                Question = question,
                                QuestionId = question.Id,
                                Answer = answer,
                                AnswerId = answer.Id,
                                CreatedBy = createBy,
                                CreatedDate = DateTime.Now
                            }
                        );
                    }
                }
                context.SaveChanges();

                context.Surveys.Add(
                    new Survey() {
                        Name = "Programming Skills",
                        CreatedBy = createBy,
                        CreatedDate = DateTime.Now
                    }
                );
                context.SaveChanges();

                foreach (Question question in context.Questions)
                {
                    context.SurveyQuestions.Add(
                        new SurveyQuestion() {
                            Question = question,
                            QuestionId = question.Id,
                            Survey = context.Surveys.FirstOrDefault(),
                            SurveyId = context.Surveys.FirstOrDefault().Id
                        }    
                    );
                }
                context.SaveChanges();
            }
        }
    }
}
