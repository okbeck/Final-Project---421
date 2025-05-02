using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class AbstractLoadableQuiz
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
            List<QuestionIF> loadedQuestions = source.LoadQuestions();
            foreach (var q in loadedQuestions)
            {
                quiz.AddQuestion(q);
            }
        }

        public QuizIF GetQuiz()
        {
            return quiz;
        }
    }

}
