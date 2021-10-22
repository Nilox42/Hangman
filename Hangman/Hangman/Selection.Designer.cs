
namespace Hangman
{
    partial class Selection
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
            this.btstart = new System.Windows.Forms.Button();
            this.tbword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(23, 68);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 23);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // tbword
            // 
            this.tbword.Location = new System.Drawing.Point(13, 42);
            this.tbword.Name = "tbword";
            this.tbword.Size = new System.Drawing.Size(100, 20);
            this.tbword.TabIndex = 1;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 122);
            this.Controls.Add(this.tbword);
            this.Controls.Add(this.btstart);
            this.Name = "Selection";
            this.Text = "Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Selection_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.TextBox tbword;
    }
}