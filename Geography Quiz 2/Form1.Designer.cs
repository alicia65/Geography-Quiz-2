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
            this.btnCheat = new System.Windows.Forms.Button();
            this.Cheat = new System.Windows.Forms.GroupBox();
            this.lblCheat = new System.Windows.Forms.Label();
            this.Cheat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(40, 190);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(132, 27);
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
            this.lblScore.Location = new System.Drawing.Point(161, 236);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: ?";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Location = new System.Drawing.Point(25, 94);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(147, 22);
            this.txtUserAnswer.TabIndex = 1;
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(263, 190);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(138, 27);
            this.btnCheat.TabIndex = 4;
            this.btnCheat.Text = "Select Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // Cheat
            // 
            this.Cheat.Controls.Add(this.lblCheat);
            this.Cheat.Location = new System.Drawing.Point(263, 78);
            this.Cheat.Name = "Cheat";
            this.Cheat.Size = new System.Drawing.Size(200, 82);
            this.Cheat.TabIndex = 5;
            this.Cheat.TabStop = false;
            this.Cheat.Text = "Cheat Results";
            // 
            // lblCheat
            // 
            this.lblCheat.AutoEllipsis = true;
            this.lblCheat.Location = new System.Drawing.Point(0, 16);
            this.lblCheat.Name = "lblCheat";
            this.lblCheat.Size = new System.Drawing.Size(200, 63);
            this.lblCheat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 291);
            this.Controls.Add(this.Cheat);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.btnCheckAnswer);
            this.Name = "Form1";
            this.Text = "Geography Quiz 2";
            this.Cheat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.GroupBox Cheat;
        private System.Windows.Forms.Label lblCheat;
    }
}

