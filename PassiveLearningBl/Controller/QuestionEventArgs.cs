using System;

namespace PassiveLearningBl.Controller
{
    public class QuestionEventArgs : EventArgs
    {
        public Question Question { get; }

        public QuestionEventArgs(Question question)
        {
            Question = question ?? throw new ArgumentNullException(nameof(question));
        }
    }
}
