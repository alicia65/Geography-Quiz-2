namespace Geography_Quiz_2
{
    partial class Form1
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
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(150, 158);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(132, 23);
            this.btnCheckAnswer.TabIndex = 2;
            this.btnCheckAnswer.Text = "Check answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // txtQuestions
            // 
            this.txtQuestions.Location = new System.Drawing.Point(25, 36);
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.ReadOnly = true;
            this.txtQuestions.Size = new System.Drawing.Size(363, 22);
            this.txtQuestions.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(156, 220);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: ?";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Location = new System.Drawing.Point(105, 98);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(220, 22);
            this.txtUserAnswer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 291);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.btnCheckAnswer);
            this.Name = "Form1";
            this.Text = "Geography Quiz 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtUserAnswer;
    }
}

