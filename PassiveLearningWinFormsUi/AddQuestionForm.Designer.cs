namespace PassiveLearningWinFormsUi
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.checkBoxIsCorrectAnswer2 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsCorrectAnswer4 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsCorrectAnswer3 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsCorrectAnswer1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestionText.Location = new System.Drawing.Point(3, 8);
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(328, 20);
            this.textBoxQuestionText.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelAnswer4);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnswer1);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnswer2);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnswer3);
            this.splitContainer1.Panel1.Controls.Add(this.labelQuestionText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIsCorrectAnswer1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIsCorrectAnswer3);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIsCorrectAnswer4);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIsCorrectAnswer2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAnswer4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAnswer3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAnswer1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAnswer2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxQuestionText);
            this.splitContainer1.Size = new System.Drawing.Size(413, 149);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(3, 11);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(49, 13);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Question";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(341, 157);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(260, 157);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Location = new System.Drawing.Point(3, 67);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer2.TabIndex = 1;
            this.labelAnswer2.Text = "Answer 2";
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer2.Location = new System.Drawing.Point(3, 64);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(254, 20);
            this.textBoxAnswer2.TabIndex = 2;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Location = new System.Drawing.Point(3, 38);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer1.TabIndex = 3;
            this.labelAnswer1.Text = "Answer 1";
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer1.Location = new System.Drawing.Point(3, 38);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(254, 20);
            this.textBoxAnswer1.TabIndex = 4;
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Location = new System.Drawing.Point(3, 93);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer3.TabIndex = 5;
            this.labelAnswer3.Text = "Answer 3";
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer3.Location = new System.Drawing.Point(3, 90);
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(254, 20);
            this.textBoxAnswer3.TabIndex = 6;
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Location = new System.Drawing.Point(3, 119);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer4.TabIndex = 7;
            this.labelAnswer4.Text = "Answer 4";
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer4.Location = new System.Drawing.Point(3, 116);
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(254, 20);
            this.textBoxAnswer4.TabIndex = 8;
            // 
            // checkBoxIsCorrectAnswer2
            // 
            this.checkBoxIsCorrectAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsCorrectAnswer2.AutoSize = true;
            this.checkBoxIsCorrectAnswer2.Location = new System.Drawing.Point(263, 66);
            this.checkBoxIsCorrectAnswer2.Name = "checkBoxIsCorrectAnswer2";
            this.checkBoxIsCorrectAnswer2.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsCorrectAnswer2.TabIndex = 9;
            this.checkBoxIsCorrectAnswer2.Text = "IsCorrect";
            this.checkBoxIsCorrectAnswer2.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsCorrectAnswer4
            // 
            this.checkBoxIsCorrectAnswer4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsCorrectAnswer4.AutoSize = true;
            this.checkBoxIsCorrectAnswer4.Location = new System.Drawing.Point(263, 118);
            this.checkBoxIsCorrectAnswer4.Name = "checkBoxIsCorrectAnswer4";
            this.checkBoxIsCorrectAnswer4.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsCorrectAnswer4.TabIndex = 10;
            this.checkBoxIsCorrectAnswer4.Text = "IsCorrect";
            this.checkBoxIsCorrectAnswer4.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsCorrectAnswer3
            // 
            this.checkBoxIsCorrectAnswer3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsCorrectAnswer3.AutoSize = true;
            this.checkBoxIsCorrectAnswer3.Location = new System.Drawing.Point(263, 92);
            this.checkBoxIsCorrectAnswer3.Name = "checkBoxIsCorrectAnswer3";
            this.checkBoxIsCorrectAnswer3.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsCorrectAnswer3.TabIndex = 11;
            this.checkBoxIsCorrectAnswer3.Text = "IsCorrect";
            this.checkBoxIsCorrectAnswer3.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsCorrectAnswer1
            // 
            this.checkBoxIsCorrectAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsCorrectAnswer1.AutoSize = true;
            this.checkBoxIsCorrectAnswer1.Location = new System.Drawing.Point(263, 40);
            this.checkBoxIsCorrectAnswer1.Name = "checkBoxIsCorrectAnswer1";
            this.checkBoxIsCorrectAnswer1.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsCorrectAnswer1.TabIndex = 12;
            this.checkBoxIsCorrectAnswer1.Text = "IsCorrect";
            this.checkBoxIsCorrectAnswer1.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 186);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddQuestionForm";
            this.Text = "AddGroupForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Label labelAnswer4;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.TextBox textBoxAnswer4;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.CheckBox checkBoxIsCorrectAnswer2;
        private System.Windows.Forms.CheckBox checkBoxIsCorrectAnswer1;
        private System.Windows.Forms.CheckBox checkBoxIsCorrectAnswer3;
        private System.Windows.Forms.CheckBox checkBoxIsCorrectAnswer4;
    }
}