using System;

namespace PassiveLearningBl.Model
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
