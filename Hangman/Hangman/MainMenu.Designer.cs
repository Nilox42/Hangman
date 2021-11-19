
namespace Hangman
{
    partial class MainMenu
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
            this.btplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btsettings = new System.Windows.Forms.Button();
            this.btend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btplay
            // 
            this.btplay.Location = new System.Drawing.Point(299, 168);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(167, 27);
            this.btplay.TabIndex = 0;
            this.btplay.Text = "Play";
            this.btplay.UseVisualStyleBackColor = true;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "HANGMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btsettings
            // 
            this.btsettings.Location = new System.Drawing.Point(299, 201);
            this.btsettings.Name = "btsettings";
            this.btsettings.Size = new System.Drawing.Size(167, 27);
            this.btsettings.TabIndex = 2;
            this.btsettings.Text = "Settings";
            this.btsettings.UseVisualStyleBackColor = true;
            this.btsettings.Click += new System.EventHandler(this.btsettings_Click);
            // 
            // btend
            // 
            this.btend.Location = new System.Drawing.Point(299, 234);
            this.btend.Name = "btend";
            this.btend.Size = new System.Drawing.Size(167, 27);
            this.btend.TabIndex = 3;
            this.btend.Text = "End";
            this.btend.UseVisualStyleBackColor = true;
            this.btend.Click += new System.EventHandler(this.btend_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btend);
            this.Controls.Add(this.btsettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsettings;
        private System.Windows.Forms.Button btend;
    }
}