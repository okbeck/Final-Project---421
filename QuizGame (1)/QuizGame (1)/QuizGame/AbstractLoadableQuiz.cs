using QuizGame;

namespace QuizGame
{
    public abstract class AbstractLoadableQuiz
    {
        protected Quiz quiz;
        protected QuestionSource source;

        public AbstractLoadableQuiz(QuestionSource source)
        {
            this.source = source;
            this.quiz = new Quiz();
        }

        public void PopulateQuiz()
        {
            var questions = source.LoadQuestions();
            foreach (var q in questions)
            {
                quiz.AddQuestion(q);
            }
        }

        public QuizIF GetQuiz() => quiz;
    }
}