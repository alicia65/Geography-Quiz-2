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
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.Location = new System.Drawing.Point(12, 36);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(267, 23);
            this.lblQuestion1.TabIndex = 0;
            this.lblQuestion1.Text = "What is the state capital of California? ";
            this.lblQuestion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.Location = new System.Drawing.Point(12, 100);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(267, 23);
            this.lblQuestion2.TabIndex = 1;
            this.lblQuestion2.Text = "What is the tallest mountain in the world? ";
            this.lblQuestion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.Location = new System.Drawing.Point(12, 160);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(301, 23);
            this.lblQuestion3.TabIndex = 2;
            this.lblQuestion3.Text = "Which country has the furthest south extent?";
            this.lblQuestion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(446, 45);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(179, 22);
            this.txtAnswer1.TabIndex = 0;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(446, 99);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(179, 22);
            this.txtAnswer2.TabIndex = 1;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(446, 160);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(179, 22);
            this.txtAnswer3.TabIndex = 2;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(283, 229);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(132, 23);
            this.btnCheckAnswer.TabIndex = 3;
            this.btnCheckAnswer.Text = "Check";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 326);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Name = "Form1";
            this.Text = "Geography Quiz 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}

