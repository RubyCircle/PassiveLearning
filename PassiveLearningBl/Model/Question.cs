using System.Collections.Generic;

namespace PassiveLearningBl.Model
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<(string Text, bool IsCorrect)> Answer { get; set; }
        public bool IsActive { get; set; } = true;

        public Question(string questionText, List<(string Text, bool IsCorrect)> answer, bool active = true)
        {
            IsActive = active;
            if (string.IsNullOrWhiteSpace(questionText))           
                throw new System.ArgumentException("Question is not set", nameof(questionText)); 
            
            QuestionText = questionText;
            Answer = answer ?? throw new System.ArgumentNullException(nameof(Answer));
        }

        public override string ToString()
        {
            string result = "";
            foreach (var (Text, _) in Answer)
            {
                result += Text + " ";
            }
            return QuestionText + "(" + result + ")";
        }
        public override bool Equals(object obj)
        {
            if (obj is Question question)
            {
                return question.QuestionText == QuestionText;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return QuestionText.GetHashCode();
        }
    }
}
