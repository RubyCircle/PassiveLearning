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
    public partial class AddGroupForm : Form
    {
        public QuestionsGroup NewQuestionsGroup { get; set; }

        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var GroupName = textBoxGroupName.Text;
            NewQuestionsGroup = new QuestionsGroup(GroupName, new List<Question>());
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
