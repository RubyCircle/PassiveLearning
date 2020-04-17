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
    public partial class QuestionBoxForm : Form
    {
        public Question Question { get; private set; }
        public bool IsCorrect { get; private set; }

        public QuestionBoxForm(Question question)
        {
            InitializeComponent();
            Question = question ?? throw new ArgumentNullException(nameof(question));
            labelQuestionText.Text = Question.QuestionText;
            buttonAnswer1.Text = Question.Answer[0].Text;
            buttonAnswer2.Text = Question.Answer[1].Text;
            buttonAnswer3.Text = Question.Answer[2].Text;
            buttonAnswer4.Text = Question.Answer[3].Text;
        }

            private void ButtonAnswer1_Click(object sender, EventArgs e)
        {
            IsCorrect = Question.Answer[0].IsCorrect;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonAnswer2_Click(object sender, EventArgs e)
        {
            IsCorrect = Question.Answer[1].IsCorrect;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonAnswer3_Click(object sender, EventArgs e)
        {
            IsCorrect = Question.Answer[2].IsCorrect;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonAnswer4_Click(object sender, EventArgs e)
        {
            IsCorrect = Question.Answer[3].IsCorrect;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
