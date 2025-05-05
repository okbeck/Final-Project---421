using System;

// Stores and calculates quiz results
namespace QuizGame
{
    public class QuizResult
    {
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan Duration => EndTime - StartTime;
        public double ScorePercentage => TotalQuestions > 0 ? (double)CorrectAnswers / TotalQuestions * 100 : 0;

        public override string ToString()
        {
            return $"Score: {CorrectAnswers}/{TotalQuestions} ({ScorePercentage:F1}%)\nTime: {Duration.TotalSeconds:F2} seconds";
        }
    }
}