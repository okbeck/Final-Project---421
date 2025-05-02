using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Quiz : QuizIF
    {
        private List<QuestionIF> questions = new List<QuestionIF>();
        private ReaderWriterLockSlim lockObj = new ReaderWriterLockSlim();
        private int currentQuestionIndex = 0;

        public void AddQuestion(QuestionIF q)
        {
            lockObj.EnterWriteLock();
            try { questions.Add(q); }
            finally { lockObj.ExitWriteLock(); }
        }

        public void Evaluate()
        {
            lockObj.EnterReadLock();
            try { foreach (var q in questions) q.Evaluate(); }
            finally { lockObj.ExitReadLock(); }
        }

        public QuestionIF GetCurrentQuestion()
        {
            lockObj.EnterReadLock();
            try { return questions.Count > 0 ? questions[currentQuestionIndex] : null; }
            finally { lockObj.ExitReadLock(); }
        }

        public void NextQuestion()
        {
            lockObj.EnterWriteLock();
            try
            {
                if (currentQuestionIndex + 1 < questions.Count)
                    currentQuestionIndex++;
                else
                    currentQuestionIndex = questions.Count - 1; // wrap around or keep at last depending on game logic
            }
            finally { lockObj.ExitWriteLock(); }
        }

        public bool HasNextQuestion()
        {
            lockObj.EnterReadLock();
            try { return currentQuestionIndex + 1 < questions.Count; }
            finally { lockObj.ExitReadLock(); }
        }
    }
}
