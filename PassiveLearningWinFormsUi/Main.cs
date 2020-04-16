using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassiveLearningBl.Model;
using PassiveLearningBl.Controller;

namespace PassiveLearningWinFormsUi
{
    public partial class Main : Form
    {
        public QuestionController QuestionController { get; set; }

        public Main()
        {
            InitializeComponent();
            var testQuestions1 = new List<Question>()
            {
                new Question("test1", new List<(string Text, bool IsCorrect)>()
                {
                   ("ff1", true),
                   ("df1", false)
                }),
                new Question("test2", new List<(string Text, bool IsCorrect)>()
                {
                   ("f2f", true),
                   ("df2", false)
                })
            };
            var testQuestions2 = new List<Question>()
            {
                new Question("test", new List<(string Text, bool IsCorrect)>()
                {
                   ("yes", true),
                   ("no", false)
                }),
                new Question("2+2", new List<(string Text, bool IsCorrect)>()
                {
                   ("4", true),
                   ("5", false)
                })
            };
            var testGroup = new List<QuestionsGroup>()
            {
                new QuestionsGroup("test1",testQuestions1),
                new QuestionsGroup("test2",testQuestions2)
            };
            QuestionController = new QuestionController(testGroup); // TODO: добавить выгрузку
            foreach (var group in QuestionController.QuestionsGroups)
            {
                listBoxQuestionGroups.Items.Add(group);
            }
        }

        private void listBoxQuestionGroups_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxQuestions.Items.Clear();

            if(listBoxQuestionGroups.SelectedItem is QuestionsGroup group)
            {
                DisplayQuestions(group);
            }
        }

        private void DisplayQuestions(QuestionsGroup group)
        {
            for (int i = 0; i < group.Questions.Count; i++)
            {            
                listBoxQuestions.Items.Add(group.Questions[i]);
            }
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            var addGroupForm = new AddGroupForm();

            if (addGroupForm.ShowDialog() == DialogResult.OK)
            {
                QuestionController.AddGroup(addGroupForm.NewQuestionsGroup);
                listBoxQuestionGroups.Items.Add(addGroupForm.NewQuestionsGroup);
            }
        }

        private void RemoveGroup_Click(object sender, EventArgs e)
        {
            if (listBoxQuestionGroups.SelectedItem is QuestionsGroup group)
            {
                QuestionController.RemoveGroup(group);
                listBoxQuestionGroups.Items.Remove(group);
                listBoxQuestionGroups.SetSelected(0, true);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestionGroups.SelectedItem is QuestionsGroup group)
            {
                var addQuestionForm = new AddQuestionForm();

                if (addQuestionForm.ShowDialog() == DialogResult.OK)
                {
                    QuestionController.AddQuestion(addQuestionForm.NewQuestion, group);
                    listBoxQuestions.Items.Add(addQuestionForm.NewQuestion);
                }
            }
        }

        private void RemoveQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestionGroups.SelectedItem is QuestionsGroup group)
            {
                if (listBoxQuestions.SelectedItem is Question question)
                {
                    QuestionController.RemoveQuestion(question, group);
                    listBoxQuestions.Items.Remove(question);
                }
            }
        }
    }
}
