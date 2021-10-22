
namespace Hangman
{
    partial class Game
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTest = new System.Windows.Forms.Label();
            this.tbtest = new System.Windows.Forms.TextBox();
            this.bttestletter = new System.Windows.Forms.Button();
            this.lbdebug = new System.Windows.Forms.Label();
            this.lbword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTest.Location = new System.Drawing.Point(99, 65);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(133, 68);
            this.lbTest.TabIndex = 0;
            this.lbTest.Text = "0";
            this.lbTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbtest
            // 
            this.tbtest.Location = new System.Drawing.Point(12, 210);
            this.tbtest.Name = "tbtest";
            this.tbtest.Size = new System.Drawing.Size(305, 20);
            this.tbtest.TabIndex = 1;
            // 
            // bttestletter
            // 
            this.bttestletter.Location = new System.Drawing.Point(95, 236);
            this.bttestletter.Name = "bttestletter";
            this.bttestletter.Size = new System.Drawing.Size(127, 25);
            this.bttestletter.TabIndex = 2;
            this.bttestletter.Text = "Test";
            this.bttestletter.UseVisualStyleBackColor = true;
            this.bttestletter.Click += new System.EventHandler(this.bttestletter_Click);
            // 
            // lbdebug
            // 
            this.lbdebug.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbdebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdebug.Location = new System.Drawing.Point(6, 275);
            this.lbdebug.Name = "lbdebug";
            this.lbdebug.Size = new System.Drawing.Size(311, 29);
            this.lbdebug.TabIndex = 3;
            this.lbdebug.Text = "0";
            this.lbdebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbword
            // 
            this.lbword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbword.Location = new System.Drawing.Point(9, 167);
            this.lbword.Name = "lbword";
            this.lbword.Size = new System.Drawing.Size(311, 29);
            this.lbword.TabIndex = 4;
            this.lbword.Text = "0";
            this.lbword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 324);
            this.Controls.Add(this.lbword);
            this.Controls.Add(this.lbdebug);
            this.Controls.Add(this.bttestletter);
            this.Controls.Add(this.tbtest);
            this.Controls.Add(this.lbTest);
            this.Name = "Game";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.TextBox tbtest;
        private System.Windows.Forms.Button bttestletter;
        private System.Windows.Forms.Label lbdebug;
        private System.Windows.Forms.Label lbword;
    }
}

