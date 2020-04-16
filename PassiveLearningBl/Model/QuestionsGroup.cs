using System.Collections.Generic;

namespace PassiveLearningBl.Model
{
    public class QuestionsGroup
    {
        public string GroupName { get; set; }
        public List<Question> Questions { get; set; }
        public bool IsActive { get; set; }

        public QuestionsGroup(string groupName, List<Question> questions, bool active = true)
        {
            if (string.IsNullOrWhiteSpace(groupName))
            {
                throw new System.ArgumentException("GroupName is not set", nameof(groupName));
            }

            GroupName = groupName;
            Questions = questions ?? throw new System.ArgumentNullException(nameof(questions));
            IsActive = active;
        }

        public override string ToString()
        {
            return GroupName;
        }
        public override bool Equals(object obj)
        {
            if (obj is QuestionsGroup group)
            {
                for (int i = 0; i < Questions.Count; i++)
                {
                    if (!group.Questions[i].Equals(Questions[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return GroupName.GetHashCode();
        }
    }
}
