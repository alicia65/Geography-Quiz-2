namespace Geography_Quiz_2
{
    partial class frmCheat
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImLazy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(83, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImLazy
            // 
            this.btnImLazy.Location = new System.Drawing.Point(286, 154);
            this.btnImLazy.Name = "btnImLazy";
            this.btnImLazy.Size = new System.Drawing.Size(101, 35);
            this.btnImLazy.TabIndex = 1;
            this.btnImLazy.Text = "I\'m Lazy";
            this.btnImLazy.UseVisualStyleBackColor = true;
            this.btnImLazy.Click += new System.EventHandler(this.btnImLazy_Click);
            // 
            // frmCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 247);
            this.Controls.Add(this.btnImLazy);
            this.Controls.Add(this.btnClose);
            this.Name = "frmCheat";
            this.Text = "frmCheat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImLazy;
    }
}