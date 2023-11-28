using lab13.Models;

namespace lab13.Services
{
    public interface IQuizService
    {
        public Quiz getCurrentQuiz();
        public QuizQuestion addNew(Quiz quiz);
        public QuizQuestion getCurrent(Quiz quiz);
        public void answerLast(QuizQuestionAnswer answer, Quiz quiz);
        public void finish(Quiz quiz);
    }
}
