using PassiveLearningBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveLearningWinFormsUi
{
    public partial class AddQuestionForm : Form
    {
        public Question NewQuestion { get; set; }

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var QuestionText = textBoxQuestionText.Text;
            var Answer1 = (textBoxAnswer1.Text, checkBoxIsCorrectAnswer1.Checked);
            var Answer2 = (textBoxAnswer2.Text, checkBoxIsCorrectAnswer2.Checked);
            var Answer3 = (textBoxAnswer3.Text, checkBoxIsCorrectAnswer3.Checked);
            var Answer4 = (textBoxAnswer4.Text, checkBoxIsCorrectAnswer4.Checked);
            NewQuestion = new Question(QuestionText, new List<(string Text, bool IsCorrect)>()
            {
                Answer1,
                Answer2,
                Answer3,
                Answer4
            });

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
