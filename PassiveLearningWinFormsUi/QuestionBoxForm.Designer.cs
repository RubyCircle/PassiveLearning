namespace PassiveLearningWinFormsUi
{
    partial class QuestionBoxForm
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
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAnswer3.Location = new System.Drawing.Point(211, 156);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(93, 23);
            this.buttonAnswer3.TabIndex = 2;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.ButtonAnswer3_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAnswer2.Location = new System.Drawing.Point(112, 156);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(93, 23);
            this.buttonAnswer2.TabIndex = 1;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.ButtonAnswer2_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswer4.Location = new System.Drawing.Point(310, 156);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(93, 23);
            this.buttonAnswer4.TabIndex = 3;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.ButtonAnswer4_Click);
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAnswer1.Location = new System.Drawing.Point(12, 156);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(93, 23);
            this.buttonAnswer1.TabIndex = 0;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.ButtonAnswer1_Click);
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(13, 13);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(29, 13);
            this.labelQuestionText.TabIndex = 4;
            this.labelQuestionText.Text = "label";
            // 
            // QuestionBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 191);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Name = "QuestionBoxForm";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Label labelQuestionText;
    }
}