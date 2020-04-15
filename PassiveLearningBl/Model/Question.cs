using System.Collections.Generic;

namespace PassiveLearningBl
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<(string Text, bool IsCorrect)> Answers { get; set; }
        public bool IsActive { get; set; } = true;

        public Question(string questionText, List<(string Text, bool IsCorrect)> answers, bool active = true)
        {
            IsActive = active;
            if (string.IsNullOrWhiteSpace(questionText))           
                throw new System.ArgumentException("Question is not set", nameof(questionText)); 
            
            QuestionText = questionText;
            Answers = answers ?? throw new System.ArgumentNullException(nameof(answers));
        }

        public override string ToString()
        {
            string result = "";
            foreach (var (Text, _) in Answers)
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
