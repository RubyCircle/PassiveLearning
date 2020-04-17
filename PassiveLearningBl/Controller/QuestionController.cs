using PassiveLearningBl.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PassiveLearningBl.Controller
{
    public class QuestionController
    {
        public List<QuestionsGroup> QuestionsGroups { get; set; }
        public double Delay { get; set; } // Seconds
        public event EventHandler<QuestionEventArgs> DisplayQuestion;

        private bool IsActive { get => !Token.IsCancellationRequested; }
        private Random rnd = new Random();
        private CancellationTokenSource TokenSource;
        private CancellationToken Token;

        public QuestionController(double delay = 3000)
        {
            QuestionsGroups = new List<QuestionsGroup>();
            Delay = delay;
        }
        public QuestionController(List<QuestionsGroup> questionsGroups,double delay = 3000)
        {
            QuestionsGroups = questionsGroups ?? throw new ArgumentNullException(nameof(questionsGroups));
            Delay = delay;
        }

        public void Start()
        {
            TokenSource = new CancellationTokenSource();
            Token = TokenSource.Token;
            Task.Run(() => Timer(), Token);
        }
        public void Stop()
        {
            TokenSource.Cancel();
        }
        private void Timer()
        {
            DateTime DisplayTime = DateTime.Now.AddSeconds(Delay);
            while (IsActive)
            {
                Thread.Sleep(1000);
                if (DisplayTime < DateTime.Now)
                {
                    var newQuestion = GetRandomQuestion();
                    if (newQuestion != null)
                    {
                        DisplayQuestion?.Invoke(this, new QuestionEventArgs(newQuestion));
                    }
                    DisplayTime = DateTime.Now.AddSeconds(Delay);                  
                }
            }
        }

        private Question GetRandomQuestion()
        {
            List<Question> activeQuestions = new List<Question>();
            for (int i = 0; i < QuestionsGroups.Count; i++)
            {
                for (int j = 0; j < QuestionsGroups[i].Questions.Count; j++)
                {
                    if (QuestionsGroups[i].Questions[j].IsActive)
                    {
                        activeQuestions.Add(QuestionsGroups[i].Questions[j]);
                    }
                }
            }
            if (activeQuestions.Count > 0)
            {
                return activeQuestions[rnd.Next(activeQuestions.Count)];
            }
            return null;
        }

        public void AddQuestion(Question question, QuestionsGroup group)
        {
            if (question == null)
            {
                throw new ArgumentNullException(nameof(question));
            }
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            if (QuestionsGroups.Find(g => g.Equals(group)) is QuestionsGroup findGroup)
            {
                findGroup.Questions.Add(question);
            }
            else
            {
                throw new ArgumentException(group + " is not find", nameof(group));
            }
        }
        public void AddGroup(QuestionsGroup group)
        {
            QuestionsGroups.Add(group);
        }

        public void RemoveQuestion(Question question, QuestionsGroup group)
        {
            if (question == null)
            {
                throw new ArgumentNullException(nameof(question));
            }
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            if (QuestionsGroups.Find(g => g.Equals(group)) is QuestionsGroup findGroup)
            {
                if (!findGroup.Questions.Remove(question))
                {
                    throw new ArgumentException(question + " is not find", nameof(question));
                }
            }
            else
            {
                throw new ArgumentException(group + " is not find", nameof(group));
            }
        }
        public void RemoveGroup(QuestionsGroup group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }

            if (!QuestionsGroups.Remove(group))
            {
                throw new ArgumentException(group + " is not find", nameof(group));
            }
        }
    }
}
